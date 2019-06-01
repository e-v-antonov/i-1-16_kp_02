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
        public SqlCommand CommandBook = new SqlCommand("select [dbo].[Book].[ID_Book], [dbo].[Book].[Book_Title], [dbo].[Book].[Writer_ID], [dbo].[Writer_Book].[Surname_Writer] + ' ' + " +
            "[dbo].[Writer_Book].[Name_Writer] + ' ' + [dbo].[Writer_Book].[Patronymic_Writer], [dbo].[Book].[Genre_Book_ID], [dbo].[Genre_Book].[Genre], " +
            "[dbo].[Book].[Publishing_Book_ID], [dbo].[Publishing_Book].[Publishing], [dbo].[Book].[Publication_Date], [dbo].[Book].[Number_Pages], " +
            "[dbo].[Book].[ISBN_Book], [dbo].[Book].[Cost_Book], [dbo].[Book].[Total_Number_Copies_Book], " +
            "[dbo].[Book].[Available_Number_Copies_Book], CONVERT([varchar] (10), [dbo].[Book].[Date_Acceptance_Book], 104) from [dbo].[Book] inner join " +
            "[dbo].[Writer_Book] on [dbo].[Book].[Writer_ID] = [dbo].[Writer_Book].[ID_Writer] inner join [dbo].[Genre_Book] on " +
            "[dbo].[Book].[Genre_Book_ID] = [dbo].[Genre_Book].[ID_Genre_Book] inner join [dbo].[Publishing_Book] on " +
            "[dbo].[Book].[Publishing_Book_ID] = [dbo].[Publishing_Book].[ID_Publishing_Book] where [dbo].[Book].[Book_Logical_Delete] = 0 " +
            "and [dbo].[Genre_Book].[Genre_Book_Logical_Delete] = 0 and [dbo].[Publishing_Book].[Publishing_Book_Logical_Delete] = 0 " +
            "and [dbo].[Writer_Book].[Writer_Book_Logical_Delete] = 0", RegistryData.DBConnectionString);
        public SqlCommand CommandWriterForComboBox = new SqlCommand("select [dbo].[Writer_Book].[ID_Writer], [dbo].[Writer_Book].[Surname_Writer] + ' ' + " +
            "[dbo].[Writer_Book].[Name_Writer] + ' ' + [dbo].[Writer_Book].[Patronymic_Writer] as \"FIO_Writer\" from [dbo].[Writer_Book] where " +
            "[dbo].[Writer_Book].[Writer_Book_Logical_Delete] = 0", RegistryData.DBConnectionString);
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
