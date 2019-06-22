using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Library
{
    public partial class FormationActsForm : Form
    {
        DataTable dtSelectedRows = new DataTable();
        private int selectedCellCount = 0;

        public FormationActsForm()
        {
            InitializeComponent();
        }

        private void FormationActsForm_Load(object sender, EventArgs e)
        {
            Thread threadListBook = new Thread(ListBookFill);
            threadListBook.Start();

            dtSelectedRows.Columns.Add(new DataColumn("Title_Book_And_Writer", typeof(string)));
            dtSelectedRows.Columns.Add(new DataColumn("Cost_Book", typeof(string)));
            dtSelectedRows.Columns.Add(new DataColumn("Total_Number_Copies_Book", typeof(string)));
            dtSelectedRows.Columns.Add(new DataColumn("Total_Cost_Books", typeof(string)));
        }

        private void ListBookFill()
        {
            DBTables dbTables = new DBTables();

            Action action = () =>
            {
                try
                {
                    dbTables.DTListBookForAct.Clear();
                    dbTables.DTListBookForActFill();
                    dbTables.dependency.OnChange += ChangeDataListBook;

                    dgvListBook.DataSource = dbTables.DTListBookForAct;
                    dgvListBook.Columns[0].HeaderText = "Название книги, автор";
                    dgvListBook.Columns[1].HeaderText = "Цена экземпляра, руб.";
                    dgvListBook.Columns[2].HeaderText = "Количество экземпляров";
                    dgvListBook.Columns[3].HeaderText = "Сумма, руб.";
                    dgvListBook.ClearSelection();
                    dgvListBook.CurrentCell = null;
                }
                catch
                {
                    MessageBox.Show("Ошибка загрузки данных из базы данных!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        private void ChangeDataListBook(object sender, SqlNotificationEventArgs e)  //отслеживание изменения в базе данных
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                ListBookFill();
            }
        }

        private void btnCreateWordAdoptionBook_Click(object sender, EventArgs e)
        {
            selectedCellCount = dgvListBook.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                ActAdoptionBookWord actAdoptionBookWord = new ActAdoptionBookWord();
                CreateTableSelectedRows();

                new Thread(() => actAdoptionBookWord.CreateActAdoptionBookWord(dtSelectedRows, false)).Start();

                MessageBox.Show("Документ сформирован успешно.", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListBook.ClearSelection();
                dgvListBook.CurrentCell = null;
                selectedCellCount = 0;
            }
            else
            {
                MessageBox.Show("Для создания документа необходимо выделить строку!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateTableSelectedRows()
        {
            dtSelectedRows.Clear();

            for (int i = 0;  i < selectedCellCount; i++)
            {
                int indexRow = dgvListBook.SelectedCells[i].RowIndex;
                dtSelectedRows.Rows.Add(dgvListBook.Rows[indexRow].Cells[0].Value.ToString(), dgvListBook.Rows[indexRow].Cells[1].Value.ToString(), 
                    dgvListBook.Rows[indexRow].Cells[2].Value.ToString(), dgvListBook.Rows[indexRow].Cells[3].Value.ToString());
            }
        }

        private void btnCreatePdfAdoptionBook_Click(object sender, EventArgs e)
        {
            selectedCellCount = dgvListBook.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                ActAdoptionBookWord actAdoptionBookWord = new ActAdoptionBookWord();
                CreateTableSelectedRows();

                new Thread(() => actAdoptionBookWord.CreateActAdoptionBookWord(dtSelectedRows, true)).Start();

                MessageBox.Show("Документ сформирован успешно.", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListBook.ClearSelection();
                dgvListBook.CurrentCell = null;
            }
            else
            {
                MessageBox.Show("Для создания документа необходимо выделить строку!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
