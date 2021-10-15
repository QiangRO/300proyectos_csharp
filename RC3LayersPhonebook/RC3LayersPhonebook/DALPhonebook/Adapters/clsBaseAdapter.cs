using System.Data.OleDb;
using System.Data;

namespace DALPhonebook.Adapters
{
    /// <summary>
    /// Base Abstract Class for all Adapters
    /// </summary>
    /// <typeparam name="T">T is a TypedDataTable (ex:dsPhonebook.Persons)</typeparam>
    public abstract class clsBaseAdapter<T> where T : DataTable, new() 
    {
        protected virtual bool insert(string pQueryInsert, OleDbParameter[] pParams4Insert)
        {
            return this.execute_Command_NonQuery(pQueryInsert, pParams4Insert);
        }

        protected virtual bool update(string pQueryUpdate, OleDbParameter[] pParams4Update)
        {
            return this.execute_Command_NonQuery(pQueryUpdate, pParams4Update);
        }

        protected virtual bool delete(string pQueryDelete, OleDbParameter[] pParams4Delete)
        {
            return this.execute_Command_NonQuery(pQueryDelete, pParams4Delete);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pQuerySelectAll"></param>
        /// <returns>TypedDataTable (ex:list of all Persons)</returns>
        protected virtual T select_All(string pQuerySelectAll)
        {
            T retTable = new T();

            OleDbDataAdapter da = new OleDbDataAdapter(pQuerySelectAll, clsSingletoConnectionManager.GetConnection2Phonebook);
            da.Fill(retTable);

            return retTable;
        }
        protected virtual T select_By(string pQuerySelect,OleDbParameter[] pParamsWhere )
        {
            T retTable = new T();

            OleDbDataAdapter da = new OleDbDataAdapter(pQuerySelect, clsSingletoConnectionManager.GetConnection2Phonebook);
            da.SelectCommand.Parameters.AddRange(pParamsWhere);

            da.Fill(retTable);

            return retTable;
        }

        private bool execute_Command_NonQuery(string pQuery, OleDbParameter[] pParams)
        {
            OleDbCommand cmd = new OleDbCommand(pQuery, clsSingletoConnectionManager.GetConnection2Phonebook);
            cmd.Parameters.AddRange(pParams);

            try
            {
                clsSingletoConnectionManager.Open_Connection2Phonebook();
                return cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                clsSingletoConnectionManager.Close_Connection_From_Phonebook();
            }
        }
    }
}
