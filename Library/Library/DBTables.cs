﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    class DBTables
    {
        public SqlCommand CommandGenreBook = new SqlCommand("select [dbo].[Genre_Book].[ID_Genre_Book], [dbo].[Genre_Book].[Genre]  from [dbo].[Genre_Book] where [dbo].[Genre_Book].[Genre_Book_Logical_Delete] = 0", RegistryData.DBConnectionString);
        //public DataTable DTGenreBook = new DataTable("Genre_Book");
        //public SqlDependency Dependency = new SqlDependency();
        //public string QRGenreBook = "select [dbo].[Genre_Book].[ID_Genre_Book], [dbo].[Genre_Book].[Genre]  from [dbo].[Genre_Book] where [dbo].[Genre_Book].[Genre_Book_Logical_Delete] = 0";
        //public static SqlDependency dependency;

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
