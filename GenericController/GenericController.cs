using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading;
using System.Web;
using System.Reflection;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace System.Linq
{
    [System.ComponentModel.DataObject]
    public class GenericController<TEntity, TDataContext>
        where TDataContext : DataContext, new()
        where TEntity : class
    {
        #region Properties
        private static string _dataContextKey;
        private static string DataContextKey
        {
            get
            {
                if (_dataContextKey == null)
                
                    _dataContextKey = "dataContext_" + typeof(TDataContext).FullName;
                
                return _dataContextKey;
            }
        }
        private static TDataContext DataContext
        {
            get
            {
                LocalDataStoreSlot threadData = Thread.GetNamedDataSlot(DataContextKey);
                object dataContext = null;

                if (threadData != null)
                    dataContext = Thread.GetData(threadData);

                if (dataContext == null)
                {
                    dataContext = CreateDataContext();
                    if (threadData == null)
                        threadData = Thread.AllocateNamedDataSlot(DataContextKey);

                    Thread.SetData(threadData, dataContext);
                }
                return (TDataContext)dataContext;
            }
        }
        private static TDataContext CreateDataContext()
        {
            var dataContext = new TDataContext();

            return dataContext;
        }
        /// <summary>
        /// Removes the current DataContext from the Request/Thread and calls dispose on it
        /// </summary>
        public static void DiscardDataContext()
        {
            LocalDataStoreSlot threadData = Thread.GetNamedDataSlot(DataContextKey);
            TDataContext dataContext = null;

            if (threadData != null)
                dataContext = (TDataContext)Thread.GetData(threadData);

            if (dataContext != null)
            {
                Thread.FreeNamedDataSlot(DataContextKey);
                dataContext.Dispose();
            }
        }

        private static Table<TEntity> EntityTable
        {
            get
            {
                return DataContext.GetTable<TEntity>();
            }
        }
        private static string EntityName
        {
            get
            {
                return EntityType.Name;
            }
        }
        private static Type EntityType
        {
            get
            {
                return typeof(TEntity);
            }
        }
        private static string TableName
        {
            get
            {
                var att = EntityType.GetCustomAttributes(typeof(TableAttribute), false).FirstOrDefault();
                return att == null ? "" : ((TableAttribute)att).Name;
            }
        }
        public static DataLoadOptions LoadOptions
        {
            get
            {
                return DataContext.LoadOptions;
            }
            set
            {
                DataContext.LoadOptions = value;
            }
        }

        private static PropertyInfo[] _columns;
        private static PropertyInfo[] Columns
        {
            get
            {
                if (_columns == null)
                {
                    //Get all the properties of this entity which have a Column attribute
                    //this is how Linq to Sql does its mapping.
                    _columns = (from p in EntityType.GetProperties()
                                where p.GetIndexParameters().Length == 0 &
                                p.GetCustomAttributes(typeof(ColumnAttribute), false).FirstOrDefault() != null
                                select p).ToArray<PropertyInfo>();
                }
                return _columns;
            }
        }
        private static PropertyInfo _primaryKey;
        private static PropertyInfo PrimaryKey
        {
            get
            {
                if (_primaryKey == null)
                {
                    foreach (PropertyInfo pi in Columns)
                    {
                        foreach (ColumnAttribute col in pi.GetCustomAttributes(typeof(ColumnAttribute), false))
                        {
                            if (col.IsPrimaryKey)
                                _primaryKey = pi;
                        }
                    }
                }
                return _primaryKey;
            }
        }

        #endregion

        #region Helper methods

        private static object GetPrimaryKeyValue(TEntity entity)
        {
            return PrimaryKey.GetValue(entity, null);
        }

        private static TEntity SelectRow(TEntity entity)
        {
            return SelectRow(GetPrimaryKeyValue(entity));
        }

        private static void UpdateOriginalFromChanged(ref TEntity destination, TEntity source)
        {
            //Update all the column properties using reflection
            foreach (PropertyInfo pi in Columns)
            {
                pi.SetValue(destination, pi.GetValue(source, null), null);
            }
        }

        #endregion

        #region Generic CRUD methods
        //---------------------Selects----------------------------------

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static IQueryable<TEntity> SelectAll(int maximumRows, int startRowIndex)
        {
            return SelectAll().Skip(startRowIndex).Take(maximumRows);
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static IQueryable<TEntity> SelectAll(int maximumRows, int startRowIndex, string SortColumnName)
        {
            return SelectAll(SortColumnName).Skip(startRowIndex).Take(maximumRows);
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static IQueryable<TEntity> SelectAll(string SortColumnName)
        {
            if (string.IsNullOrEmpty(SortColumnName))
            {
                return EntityTable;
            }
            var pi = Columns.Single(c => c.Name == SortColumnName);

            var itemParameter = Expression.Parameter(typeof(TEntity), "item");
            var whereExpression = Expression.Lambda<Func<TEntity, IComparable>>
                    (
                        Expression.Property(
                            itemParameter,
                            pi
                        ),
                    new[] { itemParameter }
                    );

            return EntityTable.OrderBy(whereExpression);
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static IQueryable<TEntity> SelectAll()
        {
            return EntityTable;
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static List<TEntity> SelectAllAsList()
        {
            return EntityTable.ToList();
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static TEntity SelectRow(object id)
        {
            //return EntityTable.SingleOrDefault(et => PrimaryKey == id);
            var itemParameter = Expression.Parameter(typeof(TEntity), "item");
            var whereExpression = Expression.Lambda<Func<TEntity, bool>>
                    (
                    Expression.Equal(
                        Expression.Property(
                            itemParameter,
                            PrimaryKey
                            ),
                        Expression.Constant(id)
                        ),
                    new[] { itemParameter }
                    );
            return EntityTable.SingleOrDefault(whereExpression);
        }

        //----------------------Count------------------------------------
        public static int Count()
        {
            return EntityTable.Count();
        }

        //----------------------Insert------------------------------------
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        public static void Insert(TEntity entity)
        {
            Insert(entity, true);
        }
        public static void Insert(TEntity entity, bool submitChanges)
        {
            EntityTable.InsertOnSubmit(entity);
            if (submitChanges)
                DataContext.SubmitChanges();
        }

        //-----------------------Update-----------------------------------------
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public static void Update(TEntity entity)
        {
            Update(entity, true);
        }
        public static void Update(TEntity entity, bool submitChanges)
        {
            TEntity original = SelectRow(entity);
            UpdateOriginalFromChanged(ref original, entity);
            if (submitChanges)
                DataContext.SubmitChanges();
        }

        //----------------------Delete-------------------------------------------
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static void Delete(TEntity entity)
        {
            Delete(entity, true);
        }
        public static void Delete(object id)
        {
            Delete(SelectRow(id), true);
        }
        public static void Delete(TEntity entity, bool submitChanges)
        {
            TEntity delete = SelectRow(entity);
            EntityTable.DeleteOnSubmit(delete);
            if (submitChanges)
                DataContext.SubmitChanges();
        }
        #endregion

        public static void SubmitChanges()
        {
            DataContext.SubmitChanges();
        }
    }
}