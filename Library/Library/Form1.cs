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
using Xceed.Words.NET;

namespace Library
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(GenreFill);
            thread.Start();
        }

        private void GenreFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                dbTables.DTGenre.Clear();
                dbTables.DTGenreFill();
                dbTables.dependency.OnChange += onChangeGenre;
                dgvRegistrationCard.DataSource = dbTables.DTGenre;

                dgvRegistrationCard.Columns[0].HeaderText = "ID";
                dgvRegistrationCard.Columns[1].HeaderText = "Genre";
            };
            Invoke(action);
        }

        private void onChangeGenre(object sender, SqlNotificationEventArgs e)  //отслеживание изменения в базе данных
        {         
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                GenreFill();                
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\Games\Library.docx";

            using (DocX document = DocX.Create(fileName))
            {
                               
            }
        }
    }
}
