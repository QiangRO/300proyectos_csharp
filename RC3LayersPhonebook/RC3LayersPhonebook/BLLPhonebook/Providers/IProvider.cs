namespace BLLBooks.Providers
{
    /// <summary>
    /// CRUD operations..interface for all EntityProviders
    /// </summary>
    /// <typeparam name="T">Type of Entity (ex:clsPersonEntity)</typeparam>
    /// <typeparam name="TPK">Type of EntityPrimaryKey (for comparing, ex:string,int)</typeparam>
    interface IProvider<T , TPK> where T :BLLBooks.Entities.clsBaseEntity 
    {
        /// <summary>
        /// Add new Item
        /// </summary>
        /// <param name="pItem4Add"></param>
        /// <returns></returns>
        bool Add(T pItem4Add);

        /// <summary>
        /// get the list of all items
        /// </summary>
        /// <returns>List of all items</returns>
        System.Collections.Generic.List<T> Get_All_Items();
   
        /// <summary>
        /// Update an existing item
        /// </summary>
        /// <param name="pItem4Update"></param>
        /// <param name="pKey4Update"></param>
        /// <returns></returns>
        bool Update(T pItem4Update , TPK pKey4Update);

        /// <summary>
        /// Delete by PK(PrimaryKey)
        /// </summary>
        /// <param name="pKey4Delete"></param>
        /// <returns></returns>
        bool Delete(TPK pKey4Delete);
    }
}
