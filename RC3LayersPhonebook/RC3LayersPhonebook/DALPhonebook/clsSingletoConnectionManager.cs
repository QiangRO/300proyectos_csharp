using System.Data.OleDb;

namespace DALPhonebook
{
    public static class clsSingletoConnectionManager
    {
        private static OleDbConnection _con2Phonebook = null;

        public static OleDbConnection GetConnection2Phonebook
        {
            get
            {
                return
                    (_con2Phonebook == null)
                    ? (_con2Phonebook = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Phonebook.mdb"))
                    : _con2Phonebook;
            }
        }

        public static void Open_Connection2Phonebook()
        {
            GetConnection2Phonebook.Open();
        }

        public static void Close_Connection_From_Phonebook()
        {
            if (_con2Phonebook == null)
                return;

            _con2Phonebook.Close();
        }
    }
}
