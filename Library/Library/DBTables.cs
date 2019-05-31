using System;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    class DBTables
    {
        public SqlCommand CommandGenreBook = new SqlCommand("select [dbo].[Genre_Book].[ID_Genre_Book], [dbo].[Genre_Book].[Genre]  " +
            "from [dbo].[Genre_Book] where [dbo].[Genre_Book].[Genre_Book_Logical_Delete] = 0", RegistryData.DBConnectionString);
        public SqlCommand CommandPublishingBook = new SqlCommand("select [dbo].[Publishing_Book].[ID_Publishing_Book], " +
            "[dbo].[Publishing_Book].[Publishing] from [dbo].[Publishing_Book] where [dbo].[Publishing_Book].[Publishing_Book_Logical_Delete] = 0", RegistryData.DBConnectionString);
        public SqlCommand CommandWriterBook = new SqlCommand("select [dbo].[Writer_Book].[ID_Writer], [dbo].[Writer_Book].[Surname_Writer], " +
            "[dbo].[Writer_Book].[Name_Writer], [dbo].[Writer_Book].[Patronymic_Writer]  from [dbo].[Writer_Book] where " +
            "[dbo].[Writer_Book].[Writer_Book_Logical_Delete] = 0", RegistryData.DBConnectionString);
        public SqlCommand CommandOpenKey = new SqlCommand("Open_Symmetric_Key", RegistryData.DBConnectionString);
        public SqlCommand CommandCloseKey = new SqlCommand("Close_Symmetric_Key", RegistryData.DBConnectionString);
        public SqlCommand CommandRegistrationCard = new SqlCommand("select [dbo].[Registration_Card_Reader].[ID_Registration_Card_Reader], " +
            "[dbo].[Registration_Card_Reader].[Surname_Reader], [dbo].[Registration_Card_Reader].[Name_Reader], " +
            "[dbo].[Registration_Card_Reader].[Patronymic_Reader], CONVERT([varchar] (10), [dbo].[Registration_Card_Reader].[Birthday_Reader], 104)," +
            " CONVERT([nvarchar] (4), DECRYPTBYKEY([dbo].[Registration_Card_Reader].[Passport_Series_Reader])), " +
            "CONVERT([nvarchar] (6), DECRYPTBYKEY([dbo].[Registration_Card_Reader].[Passport_Number_Reader])), " +
            "[dbo].[Registration_Card_Reader].[Who_Give_Passport_Reader], CONVERT([varchar] (10), " +
            "[dbo].[Registration_Card_Reader].[When_Give_Passport_Reader], 104), [dbo].[Registration_Card_Reader].[Town_Reader], " +
            "CONVERT([nvarchar] (50), DECRYPTBYKEY([dbo].[Registration_Card_Reader].[Street_Reader])), " +
            "[dbo].[Registration_Card_Reader].[Building_Reader], [dbo].[Registration_Card_Reader].[Apartment_Reader], " +
            "CONVERT([nvarchar] (15), DECRYPTBYKEY([dbo].[Registration_Card_Reader].[Home_Phone_Reader])), " +
            "CONVERT([nvarchar] (15), DECRYPTBYKEY([dbo].[Registration_Card_Reader].[Mobile_Phone_Reader])), " +
            "CONVERT([nvarchar] (129), DECRYPTBYKEY([dbo].[Registration_Card_Reader].[Email_Reader])), " +
            "[dbo].[Registration_Card_Reader].[Book_On_Hand_Reader] from [dbo].[Registration_Card_Reader] where " +
            "[dbo].[Registration_Card_Reader].[Registration_Card_Reader_Logical_Delete] = 0", RegistryData.DBConnectionString);
        //public DataTable DTGenreBook = new DataTable("Genre_Book");
        //public string QRGenreBook = "select [dbo].[Genre_Book].[ID_Genre_Book], [dbo].[Genre_Book].[Genre]  from [dbo].[Genre_Book] where [dbo].[Genre_Book].[Genre_Book_Logical_Delete] = 0";

        public void FillGenre()
        {
            //try
            //{
            //    Command.Notification = null;
            //    Command.CommandText = QRGenreBook;
            //    RegistryData.DBConnectionString.Open();
            //    DTGenreBook.Load(Command.ExecuteReader());
            //    SqlDependency dependency = new SqlDependency(Command);
            //    SqlDependency.Start(RegistryData.DBConnectionString.ConnectionString);
            //    dependency.OnChange += new OnChangeEventHandler(OnDataChanged);
            //}
            //catch (Exception ex)
            //{
            //    RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
            //}
            //finally
            //{
            //    RegistryData.DBConnectionString.Close();
            //}
        }

        public void OnDataChanged(object sender, SqlNotificationEventArgs e)
        {
            //if (e.Info != SqlNotificationInfo.Invalid)
            //{
            //    Form1 form = new Form1();
            //    form.GetData();
            //}
        }

        //private void FillDataTable(DataTable table, string query)
        //{
        //    try
        //    {
        //        //table.Clear();
        //        Command.Notification = null;
        //        Command.CommandText = query;
        //        //Dependency.AddCommandDependency(Command);
        //        //SqlDependency dependency = new SqlDependency(Command);
        //        //SqlDependency.Start(RegistryData.DBConnectionString.ConnectionString);
        //        RegistryData.DBConnectionString.Open();
        //        table.Load(Command.ExecuteReader());
        //    }
        //    catch (Exception ex)
        //    {
        //        RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
        //    }
        //    finally
        //    {
        //        RegistryData.DBConnectionString.Close();
        //    }
        //}

        //public void FillDataTableGenreBook()
        //{
        //    FillDataTable(DTGenreBook, QRGenreBook);
        //}
    }
}
