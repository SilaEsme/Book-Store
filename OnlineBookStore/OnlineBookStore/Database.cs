using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public class Database
    {
        private static Database database;
        private string connectionString = "Data Source=SQL5097.site4now.net;Initial Catalog=db_a75067_sanemyildiz;User Id=db_a75067_sanemyildiz_admin;Password=sanem4196";
        private SqlConnection sqlConnection;

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
