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
    public partial class GenreBookForm : Form
    {
        DBTables dbTables = new DBTables();
        DBStoredProcedure storedProcedure = new DBStoredProcedure();

        public GenreBookForm()
        {
            InitializeComponent();
        }

        private void GenreBookForm_Load(object sender, EventArgs e) //загрузка формы
        {
            Thread threadGenre = new Thread(GenreBookFill);
            threadGenre.Start();
        }

        private void GenreBookFill() //заполнение combo box данными из базы данных
        {
            Action action = () =>
            {
                dbTables.CommandGenreBook.Notification = null;
                SqlDependency sqlDependency = new SqlDependency(dbTables.CommandGenreBook);
                SqlDependency.Start(RegistryData.DBConnectionString.ConnectionString);
                sqlDependency.OnChange += new OnChangeEventHandler(ChangeDataGenre);
                RegistryData.DBConnectionString.Open();
                DataTable dataTable = new DataTable("Genre_Book");
                dataTable.Load(dbTables.CommandGenreBook.ExecuteReader());
                RegistryData.DBConnectionString.Close();
                ltbGenre.DataSource = dataTable;
                ltbGenre.ValueMember = "ID_Genre_Book";
                ltbGenre.DisplayMember = "Genre";
            };
            Invoke(action);
        }              

        private void ChangeDataGenre(object sender, SqlNotificationEventArgs e)  //отслеживание изменения в базе данных
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                GenreBookFill();
            }
        }

        private void ltbGenre_Click(object sender, EventArgs e) //клик по записи в combo box
        {
            tbGenre.Text = ltbGenre.Text;
        }

        private void ltbGenre_SelectedIndexChanged(object sender, EventArgs e)  //выбор записи в combo box
        {
            tbGenre.Text = ltbGenre.Text;
        }

        private void btnInsert_Click(object sender, EventArgs e)    //кнопка добавления записи
        {
            storedProcedure.SPGenreBookInsert(tbGenre.Text);
            tbGenre.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)    //кнопка изменения записи
        {
            storedProcedure.SPGenreBookUpdate(Convert.ToInt32(ltbGenre.SelectedValue.ToString()), tbGenre.Text);
            tbGenre.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)    //кнопка удаления записи
        {
            switch (MessageBox.Show("Удалить жанр книги " + ltbGenre.Text + "?", "Удаление жанра книги", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    storedProcedure.SPGenreBookDelete(Convert.ToInt32(ltbGenre.SelectedValue.ToString()));
                    break;
            }
        }

        private void btnError_Click(object sender, EventArgs e) //кнопка ошибки
        {
            MessageBox.Show(RegistryData.ErrorMessage, "Ошибки в результате работы информационной системы");
        }

        private void btnExit_Click(object sender, EventArgs e)  //кнопка закрытия окна
        {
            Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)   //введение текста в поле поиска
        {
            ltbGenre.SelectedIndex = ltbGenre.FindString(tbSearch.Text);
            ltbGenre_Click(sender, e);
        }

        private void tbSearch_Leave(object sender, EventArgs e) //поле поиска больше не в фокусе
        {
            if (tbSearch.Text == "")
                tbSearch.Text = "Введите название жанра...";
        }

        private void tbSearch_Enter(object sender, EventArgs e) //поле поиска стало активным
        {
            if (tbSearch.Text == "Введите название жанра..")
                tbSearch.Clear();
        }

        private void tbSearch_Click(object sender, EventArgs e) //клик по полю поиска
        {
            tbSearch.Clear();
        }
    }
}
