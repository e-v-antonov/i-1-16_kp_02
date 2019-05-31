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
            Thread thread = new Thread(RegistrationCardFill);
            thread.Start();
        }

        private void RegistrationCardFill()
        {
            Action action = () =>
            {
                try
                {
                    dbTables.CommandWriterBook.Notification = null;
                    SqlDependency sqlDependency = new SqlDependency(dbTables.CommandWriterBook);
                    SqlDependency.Start(RegistryData.DBConnectionString.ConnectionString);
                    sqlDependency.OnChange += new OnChangeEventHandler(ChangeDataRegistrationCard);
                    RegistryData.DBConnectionString.Open();
                    DataTable dataTable = new DataTable("Writer_Book");
                    dataTable.Load(dbTables.CommandWriterBook.ExecuteReader());
                    RegistryData.DBConnectionString.Close();
                    dgvRegistrationCard.DataSource = dataTable;
                    dgvRegistrationCard.Columns[0].Visible = false;
                    dgvRegistrationCard.Columns[1].HeaderText = "Фамилия";
                    dgvRegistrationCard.Columns[2].HeaderText = "Имя";
                    dgvRegistrationCard.Columns[3].HeaderText = "Отчество";
                    dgvRegistrationCard.ClearSelection();

                    //dbTables.CommandRegistrationCard.Notification = null;
                    //dbTables.CommandOpenKey.CommandType = System.Data.CommandType.StoredProcedure;
                    //dbTables.CommandCloseKey.CommandType = System.Data.CommandType.StoredProcedure;
                    //SqlDependency sqlDependency = new SqlDependency(dbTables.CommandRegistrationCard);
                    //SqlDependency.Start(RegistryData.DBConnectionString.ConnectionString);
                    //sqlDependency.OnChange += new OnChangeEventHandler(ChangeDataRegistrationCard);
                    //RegistryData.DBConnectionString.Open();
                    //DataTable dataTable = new DataTable("Registration_Card_Reader");
                    //dbTables.CommandOpenKey.ExecuteNonQuery();
                    //dataTable.Load(dbTables.CommandRegistrationCard.ExecuteReader());
                    //dbTables.CommandCloseKey.ExecuteNonQuery();
                    //RegistryData.DBConnectionString.Close();

                    //dgvRegistrationCard.DataSource = dataTable;
                    //dgvRegistrationCard.Columns[0].Visible = false;
                    //dgvRegistrationCard.Columns[1].HeaderText = "Фамилия";
                    //dgvRegistrationCard.Columns[2].HeaderText = "Имя";
                    //dgvRegistrationCard.Columns[3].HeaderText = "Отчество";
                    //dgvRegistrationCard.Columns[4].HeaderText = "Дата рождения";
                    //dgvRegistrationCard.Columns[5].HeaderText = "Серия паспорта";
                    //dgvRegistrationCard.Columns[6].HeaderText = "Номер паспорта";
                    //dgvRegistrationCard.Columns[7].HeaderText = "Кем выдан паспорт";
                    //dgvRegistrationCard.Columns[8].HeaderText = "Когда выдан паспорт";
                    //dgvRegistrationCard.Columns[9].HeaderText = "Город";
                    //dgvRegistrationCard.Columns[10].HeaderText = "Улица";
                    //dgvRegistrationCard.Columns[11].HeaderText = "Дом";
                    //dgvRegistrationCard.Columns[12].HeaderText = "Квартира";
                    //dgvRegistrationCard.Columns[13].HeaderText = "Номер мобильного телефона";
                    //dgvRegistrationCard.Columns[14].HeaderText = "Номер домашнего телефона";
                    //dgvRegistrationCard.Columns[15].HeaderText = "Адрес электронной почты";
                    //dgvRegistrationCard.ClearSelection();
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void ChangeDataRegistrationCard(object sender, SqlNotificationEventArgs e)  //отслеживание изменения в базе данных
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                RegistrationCardFill();
            }
        }

        //public void GetData()
        //{
        //    Action action = () =>
        //    {
        //        //dbTables.Command.Notification = null;
        //        //dbTables.Command.CommandText = dbTables.QRGenreBook;
        //        //SqlDependency dependency = new SqlDependency(dbTables.Command);
        //        //SqlDependency.Start(RegistryData.DBConnectionString.ConnectionString);
        //        //DBTables.dependency.OnChange += new OnChangeEventHandler(OnDataChanged);
        //        //RegistryData.DBConnectionString.Open();
        //        //DataTable data = new DataTable();
        //        //data.Load(dbTables.Command.ExecuteReader());
        //        //dbTables.FillDataTableGenreBook();
        //        //dbTables.FillGenre();
        //        //ltbGenre.DataSource = DBTables.DTGenreBook;
        //        //ltbGenre.ValueMember = "ID_Genre_Book";
        //        //ltbGenre.DisplayMember = "Genre";
        //        // RegistryData.DBConnectionString.Close();

        //    };
        //    Invoke(action);
        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //public void OnDataChanged(object sender, SqlNotificationEventArgs e)
        //{
        //    if (e.Info != SqlNotificationInfo.Invalid)
        //        GetData();
        //}
    }
}
