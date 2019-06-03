using System;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    class DBTables
    {
        public SqlCommand CommandGenreBook = new SqlCommand("select [ID_Genre_Book], [Genre]  " +
            "from [dbo].[Genre_Book] where [Genre_Book_Logical_Delete] = 0", RegistryData.DBConnectionString);
        public SqlCommand CommandPublishingBook = new SqlCommand("select [ID_Publishing_Book], " +
            "[Publishing] from [dbo].[Publishing_Book] where [Publishing_Book_Logical_Delete] = 0", RegistryData.DBConnectionString);
        public SqlCommand CommandWriterBook = new SqlCommand("select [ID_Writer], [Surname_Writer], " +
            "[Name_Writer], [Patronymic_Writer]  from [dbo].[Writer_Book] where " +
            "[Writer_Book_Logical_Delete] = 0", RegistryData.DBConnectionString);
        public SqlCommand CommandOpenKey = new SqlCommand("Open_Symmetric_Key", RegistryData.DBConnectionString);
        public SqlCommand CommandCloseKey = new SqlCommand("Close_Symmetric_Key", RegistryData.DBConnectionString);
        public SqlCommand CommandRegistrationCard = new SqlCommand("select [ID_Registration_Card_Reader], " +
            "[Surname_Reader], [Name_Reader], " +
            "[Patronymic_Reader], CONVERT([varchar] (10), [Birthday_Reader], 104)," +
            " CONVERT([nvarchar] (4), DECRYPTBYKEY([Passport_Series_Reader])), " +
            "CONVERT([nvarchar] (6), DECRYPTBYKEY([Passport_Number_Reader])), " +
            "[Who_Give_Passport_Reader], CONVERT([varchar] (10), " +
            "[When_Give_Passport_Reader], 104), [Town_Reader], " +
            "CONVERT([nvarchar] (50), DECRYPTBYKEY([Street_Reader])), " +
            "[Building_Reader], [Apartment_Reader], " +
            "CONVERT([nvarchar] (15), DECRYPTBYKEY([Home_Phone_Reader])), " +
            "CONVERT([nvarchar] (15), DECRYPTBYKEY([Mobile_Phone_Reader])), " +
            "CONVERT([nvarchar] (129), DECRYPTBYKEY([Email_Reader])), " +
            "[Book_On_Hand_Reader] from [dbo].[Registration_Card_Reader] where " +
            "[Registration_Card_Reader_Logical_Delete] = 0", RegistryData.DBConnectionString);
        public SqlCommand CommandBook = new SqlCommand("select [ID_Book], [Book_Title], [Writer_ID], [Surname_Writer] + ' ' + " +
            "[Name_Writer] + ' ' + [Patronymic_Writer], [Genre_Book_ID], [Genre], " +
            "[Publishing_Book_ID], [Publishing], [Publication_Date], [Number_Pages], " +
            "[ISBN_Book], [Cost_Book], [Total_Number_Copies_Book], " +
            "[Available_Number_Copies_Book], CONVERT([varchar] (10), [Date_Acceptance_Book], 104) from [dbo].[Book] inner join " +
            "[dbo].[Writer_Book] on [dbo].[Book].[Writer_ID] = [dbo].[Writer_Book].[ID_Writer] inner join [dbo].[Genre_Book] on " +
            "[dbo].[Book].[Genre_Book_ID] = [dbo].[Genre_Book].[ID_Genre_Book] inner join [dbo].[Publishing_Book] on " +
            "[dbo].[Book].[Publishing_Book_ID] = [dbo].[Publishing_Book].[ID_Publishing_Book] where [Book_Logical_Delete] = 0 " +
            "and [Genre_Book_Logical_Delete] = 0 and [Publishing_Book_Logical_Delete] = 0 " +
            "and [Writer_Book_Logical_Delete] = 0", RegistryData.DBConnectionString);
        public SqlCommand CommandWriterForComboBox = new SqlCommand("select [ID_Writer], [Surname_Writer] + ' ' + " +
            "[Name_Writer] + ' ' + [Patronymic_Writer] as \"FIO_Writer\" from [dbo].[Writer_Book] where " +
            "[Writer_Book_Logical_Delete] = 0", RegistryData.DBConnectionString);
        public SqlCommand CommandFormular = new SqlCommand("select [ID_Formular_Reader], [ID_Registration_Card_Reader], " +
            "[Surname_Reader] + ' ' + [Name_Reader] + ' ' + " +
            "[Patronymic_Reader], CONVERT([nvarchar] (4), " +
            "DECRYPTBYKEY([Passport_Series_Reader])) + ' ' + " +
            "CONVERT([nvarchar] (6), DECRYPTBYKEY([Passport_Number_Reader])), " +
            "[ID_Book], [Book_Title], CONVERT([varchar] (10), [Date_Issue_Book], 104), [Number_Days_Issue_Book], " +
            "CONVERT([varchar] (10), [Date_Return_Book], 104), [Book_Returned] from [dbo].[Formular_Reader] " +
            "inner join [dbo].[Registration_Card_Reader] on [dbo].[Formular_Reader].[Registration_Card_Reader_ID] = " +
            "[dbo].[Registration_Card_Reader].[ID_Registration_Card_Reader] inner join [dbo].[Book] on [dbo].[Formular_Reader].[Book_ID] = " +
            "[dbo].[Book].[ID_Book] where [Formular_Reader_Logical_Delete] = 0 and " +
            "[Registration_Card_Reader_Logical_Delete] = 0 and [Book_Logical_Delete] = 0", RegistryData.DBConnectionString);
        public SqlCommand CommandBookForComboBox = new SqlCommand("select [ID_Book], [Book_Title] from [dbo].[Book] where [Book_Logical_Delete] = 0", RegistryData.DBConnectionString);
        public SqlCommand CommandReaderForComboBox = new SqlCommand("select [ID_Registration_Card_Reader], " +
            "[Surname_Reader] + ' ' + [Name_Reader] + ' ' + " +
            "[Patronymic_Reader] + ', ' +  CONVERT([nvarchar] (4), " +
            "DECRYPTBYKEY([Passport_Series_Reader])) + ' ' + CONVERT([nvarchar] (6), " +
            "DECRYPTBYKEY([Passport_Number_Reader])) as \"Reader\" from [dbo].[Registration_Card_Reader]", RegistryData.DBConnectionString);


        public SqlCommand command = new SqlCommand("", RegistryData.DBConnectionString);
        public DataTable DTGenre = new DataTable("Genre");
        public DataTable DTPublishing = new DataTable("Publishing");
        public DataTable DTWriterBook = new DataTable("Writer_Book");
        public DataTable DTBook = new DataTable("Book");
        public DataTable DTRegistrationCard = new DataTable("Registration_Card_Reader");
        public string QRGenre = "select [ID_Genre_Book], [Genre] from [dbo].[Genre_Book] where [Genre_Book_Logical_Delete] = 0";
        public string QRPublishing = "select [ID_Publishing_Book],[Publishing] from [dbo].[Publishing_Book] where [Publishing_Book_Logical_Delete] = 0";
        public string QRWriterBook = "select [ID_Writer], [Surname_Writer], [Name_Writer], [Patronymic_Writer]  from [dbo].[Writer_Book] where [Writer_Book_Logical_Delete] = 0";
        public string QRBook = "select [ID_Book], [Book_Title], [Writer_ID], [Surname_Writer] + ' ' + [Name_Writer] + ' ' + [Patronymic_Writer], " +
            "[Genre_Book_ID], [Genre], [Publishing_Book_ID], [Publishing], [Publication_Date], [Number_Pages], [ISBN_Book], [Cost_Book], " +
            "[Total_Number_Copies_Book], [Available_Number_Copies_Book], CONVERT([varchar] (10), [Date_Acceptance_Book], 104) from [dbo].[Book] " +
            "inner join [dbo].[Writer_Book] on [dbo].[Book].[Writer_ID] = [dbo].[Writer_Book].[ID_Writer] inner join [dbo].[Genre_Book] on " +
            "[dbo].[Book].[Genre_Book_ID] = [dbo].[Genre_Book].[ID_Genre_Book] inner join [dbo].[Publishing_Book] on" +
            " [dbo].[Book].[Publishing_Book_ID] = [dbo].[Publishing_Book].[ID_Publishing_Book] where [Book_Logical_Delete] = 0 and " +
            "[Genre_Book_Logical_Delete] = 0 and [Publishing_Book_Logical_Delete] = 0 and [Writer_Book_Logical_Delete] = 0";
        public string QRWriterForComboBox = "select [ID_Writer], [Surname_Writer] + ' ' + [Name_Writer] + ' ' + [Patronymic_Writer] as \"FIO_Writer\" from [dbo].[Writer_Book] where [Writer_Book_Logical_Delete] = 0";
        public string QRRegistrationCard = "select [ID_Registration_Card_Reader], [Surname_Reader], [Name_Reader], [Patronymic_Reader], " +
            "CONVERT([varchar] (10), [Birthday_Reader], 104), CONVERT([nvarchar] (4), DECRYPTBYKEY([Passport_Series_Reader])), " +
            "CONVERT([nvarchar] (6), DECRYPTBYKEY([Passport_Number_Reader])), [Who_Give_Passport_Reader], CONVERT([varchar] (10), " +
            "[When_Give_Passport_Reader], 104), [Town_Reader], CONVERT([nvarchar] (50), DECRYPTBYKEY([Street_Reader])), [Building_Reader], " +
            "[Apartment_Reader], CONVERT([nvarchar] (15), DECRYPTBYKEY([Home_Phone_Reader])), CONVERT([nvarchar] (15), " +
            "DECRYPTBYKEY([Mobile_Phone_Reader])), CONVERT([nvarchar] (129), DECRYPTBYKEY([Email_Reader])), [Book_On_Hand_Reader] from " +
            "[dbo].[Registration_Card_Reader] where [Registration_Card_Reader_Logical_Delete] = 0";
        public SqlDependency dependency = new SqlDependency();

        private void DataTableFill(DataTable table, string query)
        {
            try
            {
                table.Clear();
                command.Notification = null;
                command.CommandText = query;
                dependency.AddCommandDependency(command);
                SqlDependency.Start(RegistryData.DBConnectionString.ConnectionString);
                RegistryData.DBConnectionString.Open();
                CommandOpenKey.ExecuteNonQuery();
                table.Load(command.ExecuteReader());
                CommandCloseKey.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
            }
            finally
            {
                RegistryData.DBConnectionString.Close();
            }
        }

        public void DTGenreFill()
        {
            DataTableFill(DTGenre, QRGenre);
        }

        public void DTPublishingFill()
        {
            DataTableFill(DTPublishing, QRPublishing);
        }

        public void DTWriterBookFill()
        {
            DataTableFill(DTWriterBook, QRWriterBook);
        }

        public void DTBookFill()
        {
            DataTableFill(DTBook, QRBook);
        }

        public void DTWriterForComboBoxFill()
        {
            DataTableFill(DTWriterBook, QRWriterForComboBox);
        }

        public void DTRegistrationCardFill()
        {
            DataTableFill(DTRegistrationCard, QRRegistrationCard);
        }
    }
}
