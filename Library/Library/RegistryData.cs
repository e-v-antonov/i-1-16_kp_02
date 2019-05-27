using System;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace Library
{
    class RegistryData
    {
        public static string DataSourceIP = "", DataSourceServerName = "", InitialCatalog = "", UserID = "", UserPassword = "";
        public static string ErrorMessage = "Application start: " + DateTime.Now.ToLongDateString();
        public static SqlConnection DBConnectionString = new SqlConnection();

        public void GetRegistry()   //получение данных из реестра
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey keyRegistry = registry.CreateSubKey("Library");

            try
            {
                DataSourceIP = keyRegistry.GetValue("DataSourceIP").ToString();
                DataSourceServerName = keyRegistry.GetValue("DataSourceServerName").ToString();
                InitialCatalog = keyRegistry.GetValue("InitialCatalog").ToString();
                UserID = keyRegistry.GetValue("UserID").ToString();
                UserPassword = keyRegistry.GetValue("UserPassword").ToString();
            }
            catch
            {
                keyRegistry.SetValue("DataSourceIP", "Empty");
                keyRegistry.SetValue("DataSourceServerName", "Empty");
                keyRegistry.SetValue("InitialCatalog", "Empty");
                keyRegistry.SetValue("UserID", "Empty");
                keyRegistry.SetValue("UserPassword", "Empty");
            }
            finally
            {
                DBConnectionString.ConnectionString = "Data Source = " + DataSourceIP + "\\" + DataSourceServerName + "; Initial Catalog = " + InitialCatalog +
                    "; Persist Security Info = true; " + "User ID = " + UserID + "; Password = \"" + UserPassword + "\"";
            }

        }

        public void SetRegistry(string dataSourceIP, string dataSourceServerName, string initialCatalog, string userID, string userPassword)    //отправка данных в реестр
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey keyRegistry = registry.CreateSubKey("Library");

            try
            {
                keyRegistry.SetValue("DataSourceIP", dataSourceIP);
                keyRegistry.SetValue("DataSourceServerName", dataSourceServerName);
                keyRegistry.SetValue("InitialCatalog", initialCatalog);
                keyRegistry.SetValue("UserID", userID);
                keyRegistry.SetValue("UserPassword", userPassword);
            }
            catch (Exception ex)
            {
                ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
            }
        }
    }
}
