using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Library
{
    public partial class GenreBookForm : Form
    {       
        DBStoredProcedure storedProcedure = new DBStoredProcedure();

        public GenreBookForm()
        {
            InitializeComponent();
        }

        private void UpdateEnable(bool valueUpdateEnable)   //изменение доступности кнопок
        {
            btnInsert.Enabled = valueUpdateEnable;
            btnUpdate.Enabled = valueUpdateEnable;
            btnDelete.Enabled = valueUpdateEnable;
        }

        private void GenreBookForm_Load(object sender, EventArgs e) //загрузка формы
        {
            Thread threadGenre = new Thread(GenreBookFill);
            threadGenre.Start();
        }

        private void GenreBookFill() //заполнение combo box данными из базы данных
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                dbTables.DTGenre.Clear();
                dbTables.DTGenreFill();
                dbTables.dependency.OnChange += ChangeDataGenre;

                ltbGenre.DataSource = dbTables.DTGenre;
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
            switch (MessageBox.Show(MessageUser.QuestionDeleteGenre + " " + ltbGenre.Text + "?", MessageUser.DeleteGenre, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    storedProcedure.SPGenreBookDelete(Convert.ToInt32(ltbGenre.SelectedValue.ToString()));
                    break;
            }
        }

        private void btnError_Click(object sender, EventArgs e) //кнопка ошибки
        {
            MessageBox.Show(RegistryData.ErrorMessage, MessageUser.TitleError);
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
                tbSearch.Text = MessageUser.EnterNameGenre;
        }

        private void tbSearch_Enter(object sender, EventArgs e) //поле поиска стало активным
        {
            if (tbSearch.Text == MessageUser.EnterNameGenre)
                tbSearch.Clear();
        }

        private void tbSearch_Click(object sender, EventArgs e) //клик по полю поиска
        {
            tbSearch.Clear();
        }
    }
}
