using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TheWebKingRepository.ADO
{
    public class ADOConnectionString
    {
        public string ConnectionString { get; private set; }

        public ADOConnectionString()
        {
            ConnectionString = Properties.Settings.Default.ConnectionString;
        }
    }

    class ADOUserRepository
    {
        private SqlConnection sqlConnection = null;
        private ADOConnectionString aDOConnectionString = null;       

        protected SqlConnection GetConnection()
        {
            if (sqlConnection == null)
            {
                aDOConnectionString = new ADOConnectionString();
                sqlConnection = new SqlConnection(aDOConnectionString.ConnectionString);
            }
            return sqlConnection;
        }

        public void GetUserDetails()
        {
            CreateCommand("select * from [User]");
            Console.ReadLine();
        }
        private void CreateCommand(string queryString)
        {
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                var a = command.ExecuteReader();
                while (a.Read())
                {
                    Console.WriteLine(a[0]);
                }
            }
        }
    }
}
