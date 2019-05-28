using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        DBTables dbTables = new DBTables();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(GetData);
            thread.Start();
            //GetData();
        }

        public void GetData()
        {
            Action action = () =>
            {
                //dbTables.Command.Notification = null;
                //dbTables.Command.CommandText = dbTables.QRGenreBook;
                //SqlDependency dependency = new SqlDependency(dbTables.Command);
                //SqlDependency.Start(RegistryData.DBConnectionString.ConnectionString);
                //DBTables.dependency.OnChange += new OnChangeEventHandler(OnDataChanged);
                //RegistryData.DBConnectionString.Open();
                //DataTable data = new DataTable();
                //data.Load(dbTables.Command.ExecuteReader());
                //dbTables.FillDataTableGenreBook();
                dbTables.FillGenre();
                //ltbGenre.DataSource = DBTables.DTGenreBook;
                ltbGenre.ValueMember = "ID_Genre_Book";
                ltbGenre.DisplayMember = "Genre";
                // RegistryData.DBConnectionString.Close();

            };
            Invoke(action);
        }

        //public void OnDataChanged(object sender, SqlNotificationEventArgs e)
        //{
        //    if (e.Info != SqlNotificationInfo.Invalid)
        //        GetData();
        //}
    }
}
