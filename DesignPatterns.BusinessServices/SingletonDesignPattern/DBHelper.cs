namespace DesignPatterns.BusinessServices
{
    public class DBHelper
    {
        private DBHelper(string connectionString)
        {
            this.m_ConnectionString = connectionString;
        }

        private string m_ConnectionString;

        private static DBHelper m_DBHelper;
        public static DBHelper CreateDBHelper(string connectionString)
        {
            if (m_DBHelper == null)
            {
                m_DBHelper = new DBHelper(connectionString);
            }
            return m_DBHelper;
        }

    }
}
