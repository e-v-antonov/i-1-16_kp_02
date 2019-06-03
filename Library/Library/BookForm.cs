using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Library
{
    public partial class BookForm : Form
    {        
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private SqlCommand commandSearchBook = new SqlCommand("", RegistryData.DBConnectionString);
        private DateTime dateToday;
        private string today = "";
        private string filterBook = "";

        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)  //загрузка формы
        {
            Thread threadBookFill = new Thread(BookFill);
            Thread threadWriterBookFill = new Thread(WriterBookFill);
            Thread threadPublushingFill = new Thread(PublishingFill);
            Thread threadGenreFill = new Thread(GenreFill);

            threadBookFill.Start();
            threadWriterBookFill.Start();
            threadPublushingFill.Start();
            threadGenreFill.Start();
        }

        private void BookFill() //заполнение data grid view данными из базы данных
        {
            DBTables dbTables = new DBTables();

            Action action = () =>
            {
                try
                {
                    dbTables.DTBook.Clear();
                    dbTables.DTBookFill();
                    dbTables.dependency.OnChange += ChangeDataBook;
                    filterBook = dbTables.QRBook;

                    dgvBook.DataSource = dbTables.DTBook;
                    dgvBook.Columns[0].Visible = false;
                    dgvBook.Columns[1].HeaderText = "Название книги";
                    dgvBook.Columns[2].Visible = false;
                    dgvBook.Columns[3].HeaderText = "Автор";
                    dgvBook.Columns[4].Visible = false;
                    dgvBook.Columns[5].HeaderText = "Жанр";
                    dgvBook.Columns[6].Visible = false;
                    dgvBook.Columns[7].HeaderText = "Издательство";
                    dgvBook.Columns[8].HeaderText = "Год издания";
                    dgvBook.Columns[9].HeaderText = "Количество страниц";
                    dgvBook.Columns[10].HeaderText = "Номер ISBN";
                    dgvBook.Columns[11].HeaderText = "Стоимость экземпляра";
                    dgvBook.Columns[12].HeaderText = "Общее количество экземпляров";
                    dgvBook.Columns[13].HeaderText = "Доступное количество экземпляров";
                    dgvBook.Columns[14].HeaderText = "Дата регистрации книги";
                    dgvBook.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("Ошибка загрузки данных из базы данных!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        private void ChangeDataBook(object sender, SqlNotificationEventArgs e)  //отслеживание изменения в базе данных
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                BookFill();
            }
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)  //клик по полю data grid view
        {
            tbBookTitle.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
            tbDatePublication.Text = dgvBook.CurrentRow.Cells[8].Value.ToString();
            tbNumberPages.Text = dgvBook.CurrentRow.Cells[9].Value.ToString();
            tbISBN.Text = dgvBook.CurrentRow.Cells[10].Value.ToString();
            tbCostBook.Text = dgvBook.CurrentRow.Cells[11].Value.ToString();
            tbTotalCopies.Text = dgvBook.CurrentRow.Cells[12].Value.ToString();
            tbAvailableCopies.Text = dgvBook.CurrentRow.Cells[13].Value.ToString();
            tbDateRegistration.Text = dgvBook.CurrentRow.Cells[14].Value.ToString();
            cbWriter.SelectedValue = dgvBook.CurrentRow.Cells[2].Value.ToString();
            cbPublishing.SelectedValue = dgvBook.CurrentRow.Cells[4].Value.ToString();
            cbGenre.SelectedValue = dgvBook.CurrentRow.Cells[6].Value.ToString();
        }

        private void WriterBookFill()   //заполнение combo box данными из базы данных
        {
            DBTables dbTables = new DBTables();

            Action action = () =>
            {
                try
                {
                    dbTables.DTWriterBook.Clear();
                    dbTables.DTWriterForComboBoxFill();
                    dbTables.dependency.OnChange += ChangeDataWriterBook;

                    cbWriter.DataSource = dbTables.DTWriterBook;
                    cbWriter.ValueMember = "ID_Writer";
                    cbWriter.DisplayMember = "FIO_Writer";
                    cbWriter.SelectedValue = -1;
                }
                catch
                {
                    MessageBox.Show("Ошибка загрузки данных из базы данных!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        private void PublishingFill()   //заполнение combo box данными из базы данных
        {
            DBTables dbTables = new DBTables();

            Action action = () =>
            {
                try
                {
                    dbTables.DTPublishing.Clear();
                    dbTables.DTPublishingFill();
                    dbTables.dependency.OnChange += ChangeDataPublishing;

                    cbPublishing.DataSource = dbTables.DTPublishing;
                    cbPublishing.ValueMember = "ID_Publishing_Book";
                    cbPublishing.DisplayMember = "Publishing";
                    cbPublishing.SelectedValue = -1;
                }
                catch
                {
                    MessageBox.Show("Ошибка загрузки данных из базы данных!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        private void GenreFill()    //заполнение combo box данными из базы данных
        {
            DBTables dbTables = new DBTables();

            Action action = () =>
            {
                try
                {
                    dbTables.DTGenre.Clear();
                    dbTables.DTGenreFill();
                    dbTables.dependency.OnChange += ChangeDataGenre;

                    cbGenre.DataSource = dbTables.DTGenre;
                    cbGenre.ValueMember = "ID_Genre_Book";
                    cbGenre.DisplayMember = "Genre";
                    cbGenre.SelectedValue = -1;
                }
                catch
                {
                    MessageBox.Show("Ошибка загрузки данных из базы данных!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        private void ChangeDataWriterBook(object sender, SqlNotificationEventArgs e)  //отслеживание изменения в базе данных
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                WriterBookFill();
            }
        }

        private void ChangeDataPublishing(object sender, SqlNotificationEventArgs e)  //отслеживание изменения в базе данных
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                PublishingFill();
            }
        }

        private void ChangeDataGenre(object sender, SqlNotificationEventArgs e)  //отслеживание изменения в базе данных
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                GenreFill();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)    //кнопка добавления записи
        {
            dateToday = DateTime.Now;
            today = dateToday.Date.ToString("yyyy-MM-dd");

            try
            {
                storedProcedure.SPBookInsert(tbBookTitle.Text, Convert.ToInt32(tbDatePublication.Text), Convert.ToInt32(tbNumberPages.Text), 
                    tbISBN.Text, Convert.ToInt32(tbCostBook.Text), Convert.ToInt32(tbTotalCopies.Text), today, 
                    Convert.ToInt32(cbWriter.SelectedValue.ToString()), Convert.ToInt32(cbGenre.SelectedValue.ToString()),
                    Convert.ToInt32(cbPublishing.SelectedValue.ToString()));
            }
            catch
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + " Поля Год издания, Количество страниц, Стоимость экземпляра, Общее количество экземпляров должны быть заполнены целыми числами! Проверьте правильность " + tbSearch.Text + "ода данных!";
            }

            tbBookTitle.Clear();
            tbDatePublication.Clear();
            tbNumberPages.Clear();
            tbISBN.Clear();
            tbCostBook.Clear();
            tbTotalCopies.Clear();
            tbAvailableCopies.Clear();
            tbDateRegistration.Clear();
            cbWriter.SelectedIndex = -1;
            cbPublishing.SelectedIndex = -1;
            cbGenre.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)    //кнопка изменения записи
        {
            dateToday = DateTime.Now;
            today = dateToday.Date.ToString("yyyy-MM-dd");

            try
            {
                storedProcedure.SPBookUpdate(Convert.ToInt32(dgvBook.CurrentRow.Cells[0].Value.ToString()), tbBookTitle.Text, 
                    Convert.ToInt32(tbDatePublication.Text), Convert.ToInt32(tbNumberPages.Text),
                    tbISBN.Text, Convert.ToInt32(tbCostBook.Text), Convert.ToInt32(tbTotalCopies.Text), today,
                    Convert.ToInt32(cbWriter.SelectedValue.ToString()), Convert.ToInt32(cbGenre.SelectedValue.ToString()),
                    Convert.ToInt32(cbPublishing.SelectedValue.ToString()));
            }
            catch
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + " Поля Год издания, Количество страниц, Стоимость экземпляра, Общее количество экземпляров должны быть заполнены целыми числами! Проверьте правильность " + tbSearch.Text + "ода данных!";
            }

            tbBookTitle.Clear();
            tbDatePublication.Clear();
            tbNumberPages.Clear();
            tbISBN.Clear();
            tbCostBook.Clear();
            tbTotalCopies.Clear();
            tbAvailableCopies.Clear();
            tbDateRegistration.Clear();
            cbWriter.SelectedIndex = -1;
            cbPublishing.SelectedIndex = -1;
            cbGenre.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)    //кнопка удаления записи
        {
            switch (MessageBox.Show("Удалить данные книги " + tbBookTitle.Text + "?", "Удаление данных книги", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    storedProcedure.SPBookDelete(Convert.ToInt32(dgvBook.CurrentRow.Cells[0].Value.ToString()));
                    tbBookTitle.Clear();
                    tbDatePublication.Clear();
                    tbNumberPages.Clear();
                    tbISBN.Clear();
                    tbCostBook.Clear();
                    tbTotalCopies.Clear();
                    tbAvailableCopies.Clear();
                    tbDateRegistration.Clear();
                    cbWriter.SelectedIndex = -1;
                    cbPublishing.SelectedIndex = -1;
                    cbGenre.SelectedIndex = -1;
                    break;
            }
        }

        private void tbSearch_Click(object sender, EventArgs e) //клик по полю поиска
        {
            tbSearch.Clear();
        }

        private void tbSearch_Enter(object sender, EventArgs e) //поле поиска стало активным
        {
            if (tbSearch.Text == "" + tbSearch.Text + "Введите данные книги...")
                tbSearch.Clear();
        }

        private void tbSearch_Leave(object sender, EventArgs e) //поле поиска больше не в фокусе
        {
            if (tbSearch.Text == "")
                tbSearch.Text = "" + tbSearch.Text + "Введите данные книги...";
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)   //введение текста в поле поиска
        {
            chbFiltration_CheckedChanged(sender, e);
        }

        private void chbFiltration_CheckedChanged(object sender, EventArgs e)   //изменение check box
        {
            switch (chbFiltration.CheckState)
            {
                case (CheckState.Checked):  //фильтрация
                    DataTable data = new DataTable("Book");
                    commandSearchBook.Notification = null;
                    commandSearchBook.CommandText = filterBook + " and [Book_Title] like '%" + tbSearch.Text + "%' or [Publication_Date] like '%" + tbSearch.Text + "%' " +
                        "or [Number_Pages] like '%" + tbSearch.Text + "%' or [ISBN_Book] like '%" + tbSearch.Text + "%' or [Cost_Book] like '%" + tbSearch.Text + "%' or [Total_Number_Copies_Book] like '%" + tbSearch.Text + "%' or" +
                        " CONVERT([varchar] (10), [Date_Acceptance_Book], 104) like '%" + tbSearch.Text + "%' or [Available_Number_Copies_Book] like '%" + tbSearch.Text + "%' or " +
                        "[dbo].[Genre_Book].[Genre] like '%" + tbSearch.Text + "%' or [dbo].[Publishing_Book].[Publishing] like '%" + tbSearch.Text + "%' or " +
                        "[dbo].[Writer_Book].[Surname_Writer] like '%" + tbSearch.Text + "%' or [dbo].[Writer_Book].[Name_Writer] like '%" + tbSearch.Text + "%' or " +
                        "[dbo].[Writer_Book].[Patronymic_Writer] like '%" + tbSearch.Text + "%'";

                    RegistryData.DBConnectionString.Open();
                    data.Load(commandSearchBook.ExecuteReader());
                    RegistryData.DBConnectionString.Close();

                    dgvBook.DataSource = data;
                    dgvBook.Columns[0].Visible = false;
                    dgvBook.Columns[1].HeaderText = "Название книги";
                    dgvBook.Columns[2].Visible = false;
                    dgvBook.Columns[3].HeaderText = "Автор";
                    dgvBook.Columns[4].Visible = false;
                    dgvBook.Columns[5].HeaderText = "Жанр";
                    dgvBook.Columns[6].Visible = false;
                    dgvBook.Columns[7].HeaderText = "Издательство";
                    dgvBook.Columns[8].HeaderText = "Год издания";
                    dgvBook.Columns[9].HeaderText = "Количество страниц";
                    dgvBook.Columns[10].HeaderText = "Номер ISBN";
                    dgvBook.Columns[11].HeaderText = "Стоимость экземпляра";
                    dgvBook.Columns[12].HeaderText = "Общее количество экземпляров";
                    dgvBook.Columns[13].HeaderText = "Доступное количество экземпляров";
                    dgvBook.Columns[14].HeaderText = "Дата регистрации книги";
                    dgvBook.ClearSelection();
                    break;

                case (CheckState.Unchecked):    //поиск
                    BookFill();

                    for (int i = 0; i < dgvBook.RowCount; i++)
                    {
                        for (int j = 0; j < dgvBook.ColumnCount; j++)
                        {
                            if (dgvBook.Rows[i].Cells[j].Value != null)
                                if (dgvBook.Rows[i].Cells[j].Value.ToString().Contains(tbSearch.Text))
                                {
                                    dgvBook.Rows[i].Selected = true;
                                    break;
                                }
                        }
                    }
                    break;
            }
        }

        private void btnUpdateWriter_Click(object sender, EventArgs e)  //открытие справочника авторы
        {
            WriterBookForm writerBookForm = new WriterBookForm();
            writerBookForm.Show(this);
        }

        private void btnUpdatePublishing_Click(object sender, EventArgs e)  //открытие справочника издательства
        {
            PublishingBookForm publishingBookForm = new PublishingBookForm();
            publishingBookForm.Show(this);
        }

        private void btnUpdateGenre_Click(object sender, EventArgs e)  //открытие справочника жанры
        {
            GenreBookForm genreBookForm = new GenreBookForm();
            genreBookForm.Show(this);
        }

        private void btnError_Click(object sender, EventArgs e) //кнопка ошибки
        {
            MessageBox.Show(RegistryData.ErrorMessage, "Ошибки в результате работы информационной системы");
        }

        private void btnExit_Click(object sender, EventArgs e)   //кнопка закрыть
        {
            Close();
        }
    }
}
