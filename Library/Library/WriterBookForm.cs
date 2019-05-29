using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Library
{
    public partial class WriterBookForm : Form
    {
        DBTables dbTables = new DBTables();
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private SqlCommand commandSearchWriter = new SqlCommand("", RegistryData.DBConnectionString);

        public WriterBookForm()
        {
            InitializeComponent();
        }

        private void WriterBookForm_Load(object sender, EventArgs e)     //загрузка формы
        {
            Thread threadWriter = new Thread(WriterBookFill);
            threadWriter.Start();
        }

        private void WriterBookFill()   //заполнение data grid view данными из базы данных
        {
            Action action = () =>
            {
                try
                {
                    dbTables.CommandWriterBook.Notification = null;
                    SqlDependency sqlDependency = new SqlDependency(dbTables.CommandWriterBook);
                    SqlDependency.Start(RegistryData.DBConnectionString.ConnectionString);
                    sqlDependency.OnChange += new OnChangeEventHandler(ChangeDataWriter);
                    RegistryData.DBConnectionString.Open();
                    DataTable dataTable = new DataTable("Writer_Book");
                    dataTable.Load(dbTables.CommandWriterBook.ExecuteReader());
                    RegistryData.DBConnectionString.Close();
                    dgvWriterBook.DataSource = dataTable;
                    dgvWriterBook.Columns[0].Visible = false;
                    dgvWriterBook.Columns[1].HeaderText = "Фамилия";
                    dgvWriterBook.Columns[2].HeaderText = "Имя";
                    dgvWriterBook.Columns[3].HeaderText = "Отчество";
                    dgvWriterBook.ClearSelection();
                }
                catch
                {

                }
            };
            Invoke(action);
        }

        private void ChangeDataWriter(object sender, SqlNotificationEventArgs e)  //отслеживание изменения в базе данных
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                WriterBookFill();
            }
        }

        private void dgvWriterBook_CellClick(object sender, DataGridViewCellEventArgs e) //клик по полю data grid view
        {
            tbSurnameWriter.Text = dgvWriterBook.CurrentRow.Cells[1].Value.ToString();
            tbNameWriter.Text = dgvWriterBook.CurrentRow.Cells[2].Value.ToString();
            tbPatronymicWriter.Text = dgvWriterBook.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)     //кнопка добавления записи
        {
            storedProcedure.SPWriterBookInsert(tbSurnameWriter.Text, tbNameWriter.Text, tbPatronymicWriter.Text);
            tbSurnameWriter.Clear();
            tbNameWriter.Clear();
            tbPatronymicWriter.Clear();
            dgvWriterBook.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)    //кнопка изменения записи
        {
            storedProcedure.SPWriterBookUpdate(Convert.ToInt32(dgvWriterBook.CurrentRow.Cells[0].Value.ToString()), tbSurnameWriter.Text, tbNameWriter.Text, tbPatronymicWriter.Text);
            tbSurnameWriter.Clear();
            tbNameWriter.Clear();
            tbPatronymicWriter.Clear();
            dgvWriterBook.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)     //кнопка удаления записи
        {
            switch (MessageBox.Show("Удалить автора " + tbSurnameWriter.Text + " " + tbNameWriter.Text + " " + tbPatronymicWriter.Text + "?", "Удаление автора", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    storedProcedure.SPWriterBookDelete(Convert.ToInt32(dgvWriterBook.CurrentRow.Cells[0].Value.ToString()));
                    break;
            }
        }

        private void tbSearch_Click(object sender, EventArgs e) //клик по полю поиска
        {
            tbSearch.Clear();
        }

        private void tbSearch_Enter(object sender, EventArgs e) //поле поиска стало активным
        {
            if (tbSearch.Text == "Введите данные автора...")
                tbSearch.Clear();
        }

        private void tbSearch_Leave(object sender, EventArgs e) //поле поиска больше не в фокусе
        {
            if (tbSearch.Text == "")
                tbSearch.Text = "Введите данные автора...";
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)   //введение текста в поле поиска
        {
            chbFiltration_CheckedChanged(sender, e);
        }

        private void chbFiltration_CheckedChanged(object sender, EventArgs e)   //изменение check box
        {
            switch (chbFiltration.CheckState)
            {
                case (CheckState.Checked):
                    DataTable data = new DataTable("Writer_Book");
                    commandSearchWriter.CommandText = dbTables.CommandWriterBook.CommandText + " and [Surname_Writer] like '%" + tbSearch.Text 
                        + "%' or [Name_Writer] like '%" + tbSearch.Text + "%' or [Patronymic_Writer] like '%" + tbSearch.Text + "%'";
                    RegistryData.DBConnectionString.Open();
                    data.Load(commandSearchWriter.ExecuteReader());
                    RegistryData.DBConnectionString.Close();
                    dgvWriterBook.DataSource = data;
                    dgvWriterBook.Columns[0].Visible = false;
                    dgvWriterBook.Columns[1].HeaderText = "Фамилия";
                    dgvWriterBook.Columns[2].HeaderText = "Имя";
                    dgvWriterBook.Columns[3].HeaderText = "Отчество";
                    dgvWriterBook.ClearSelection();
                    break;
                case (CheckState.Unchecked):
                    WriterBookFill();
                    for (int i = 0; i < dgvWriterBook.RowCount; i++)
                    {
                        for (int j = 0; j < dgvWriterBook.ColumnCount; j++)
                        {
                            if (dgvWriterBook.Rows[i].Cells[j].Value != null)
                                if (dgvWriterBook.Rows[i].Cells[j].Value.ToString().Contains(tbSearch.Text))
                                {
                                    dgvWriterBook.Rows[i].Selected = true;
                                    break;
                                }
                        }
                    }
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
    }
}
