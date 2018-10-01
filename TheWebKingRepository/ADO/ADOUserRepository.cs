using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TheWebKingRepository.ADO
{
    class ADOUserRepository
    {
        public string ConnectionString = null;
        SqlConnection sqlConnection = null;

        public SqlConnection GetConnection(string connectionString)
        {
            if(sqlConnection == null)
            {
                sqlConnection = new SqlConnection(connectionString);
            }
            return sqlConnection;
        }

        public void GetUserDetails()
        {
            string Server, Database, UserId, Password;
            XDocument doc = XDocument.Load("../../ConnectionConfig.xml");
            var connctionString = doc.Descendants("ConnctionString");
            Server = connctionString.Descendants("Server").ToArray()[0].Value;
            Database = connctionString.Descendants("Database").ToArray()[0].Value;
            UserId = connctionString.Descendants("UserId").ToArray()[0].Value;
            Password = connctionString.Descendants("Password").ToArray()[0].Value;

            ConnectionString = "Data Source=" + Server + ";Initial Catalog=" + Database + ";User ID=" + UserId + ";Password=" + Password;

            Console.ReadLine();
        }
        private static void CreateCommand(string queryString, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
