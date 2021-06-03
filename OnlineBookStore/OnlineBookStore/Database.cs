using System.Data.SqlClient;

namespace OnlineBookStore
{
    public class Database
    {
        private static Database database;
      
        private string connectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=db_a75067_sanemyildiz;User Id=db_a75067_sanemyildiz_admin;Password=sanem4196";
        private SqlConnection sqlConnection;

        public string ConnectionString
        {
            get => connectionString;
        }

        public void GetConnection()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public SqlConnection Sqlconnection
        {
            get => sqlConnection;
        }

        public static Database CreateSingle()
        {
            if (database == null)
            {
                database = new Database();
            }
            return database;
        }
    }
}