using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Library
{
    class DBConnection
    {        
        public event Action<DataTable> DataTableServers;
        public event Action<DataTable> DataTableDatabases;
        public event Action<bool> ConnectionState;
        public string ConnectionDS, ConnectionUID, ConnectionPassword;
        public static bool LogConnection;
        RegistryData registryData = new RegistryData();


        public void GetServers()
        {
            SqlDataSourceEnumerator sqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance;

            DataTableServers(sqlDataSourceEnumerator.GetDataSources());
        }

        public void GetDataBases()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = " + ConnectionDS + "; Initial Catalog = master; Persist Security Info = true; " +
                " User ID = " + ConnectionUID + "; Password = \"" + ConnectionPassword + "\"");

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select name from sys.databases where name not in ('master','tempdb','model','msdb')", sqlConnection);
                DataTable dataTable = new DataTable();

                sqlConnection.Open();
                dataTable.Load(sqlCommand.ExecuteReader());
                DataTableDatabases(dataTable);
            }
            catch (SqlException ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void CheckConnection()
        {
            registryData.GetRegistry();

            try
            {
                RegistryData.DBConnectionString.Open();
                ConnectionState(true);
                LogConnection = true;
            }
            catch (Exception ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
                ConnectionState(false);
                LogConnection = false;                
            }
            finally
            {
                RegistryData.DBConnectionString.Close();
            }
        }
    }
}
