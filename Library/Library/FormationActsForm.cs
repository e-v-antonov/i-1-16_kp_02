using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Library
{
    public partial class FormationActsForm : Form
    {
        private DataTable dtSelectedRows = new DataTable();
        private DataTable dtSelectedExceptionRows = new DataTable();
        private int selectedCellCount = 0;

        public FormationActsForm()
        {
            InitializeComponent();
        }

        private void FormationActsForm_Load(object sender, EventArgs e) //загрузка формы
        {
            Thread threadListBook = new Thread(ListBookFill);
            threadListBook.Start();

            dtSelectedRows.Columns.Add(new DataColumn("Title_Book_And_Writer", typeof(string)));
            dtSelectedRows.Columns.Add(new DataColumn("Cost_Book", typeof(string)));
            dtSelectedRows.Columns.Add(new DataColumn("Total_Number_Copies_Book", typeof(string)));
            dtSelectedRows.Columns.Add(new DataColumn("Total_Cost_Books", typeof(string)));

            dtSelectedExceptionRows.Columns.Add(new DataColumn("ID_Book", typeof(string)));
            dtSelectedExceptionRows.Columns.Add(new DataColumn("Title_Book_And_Writer", typeof(string)));
            dtSelectedExceptionRows.Columns.Add(new DataColumn("Cost_Book", typeof(string)));
            dtSelectedExceptionRows.Columns.Add(new DataColumn("Total_Number_Copies_Book", typeof(string)));
            dtSelectedExceptionRows.Columns.Add(new DataColumn("Total_Cost_Books", typeof(string)));
        }

        private void ListBookFill() //заполнение data grid view данными из базы данных
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
                    dgvListBook.Columns[0].Visible = false;
                    dgvListBook.Columns[1].HeaderText = MessageUser.TitleBookAct;
                    dgvListBook.Columns[2].HeaderText = MessageUser.CounPriceAct;
                    dgvListBook.Columns[3].HeaderText = MessageUser.CountInstanceAct;
                    dgvListBook.Columns[4].HeaderText = MessageUser.SummAct;
                    dgvListBook.ClearSelection();
                    dgvListBook.CurrentCell = null;
                }
                catch
                {
                    MessageBox.Show(MessageUser.ErrorLoadingData, MessageUser.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCreateWordAdoptionBook_Click(object sender, EventArgs e)    //клик по кнопке формирование акта о приемке в формате docx
        {
            selectedCellCount = dgvListBook.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                ActAdoptionBookWord actAdoptionBookWord = new ActAdoptionBookWord();
                CreateTableSelectedRows();

                new Thread(() => actAdoptionBookWord.CreateActAdoptionBookWord(dtSelectedRows, false)).Start();

                MessageBox.Show(MessageUser.DocumentCreateSucc, MessageUser.TitleLibrary, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListBook.ClearSelection();
                dgvListBook.CurrentCell = null;
                selectedCellCount = 0;
            }
            else
            {
                MessageBox.Show(MessageUser.NeedSelectRow, MessageUser.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateTableSelectedRows()  //запоминание выбранных записей для акта о приемке
        {
            dtSelectedRows.Clear();

            for (int i = 0; i < dgvListBook.RowCount; i++)
            {
                for (int j = 0; j < dgvListBook.ColumnCount; j++)
                {
                    if (dgvListBook.Rows[i].Cells[j].Selected == true)
                    {
                        dtSelectedRows.Rows.Add(dgvListBook.Rows[i].Cells[1].Value.ToString(), dgvListBook.Rows[i].Cells[2].Value.ToString(),
                            dgvListBook.Rows[i].Cells[3].Value.ToString(), dgvListBook.Rows[i].Cells[4].Value.ToString());
                        break;
                    }
                }
            }
        }

        private void btnCreatePdfAdoptionBook_Click(object sender, EventArgs e) //клик по кнопке формирование акта о приемке в формате pdf
        {
            selectedCellCount = dgvListBook.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                ActAdoptionBookWord actAdoptionBookWord = new ActAdoptionBookWord();
                CreateTableSelectedRows();

                new Thread(() => actAdoptionBookWord.CreateActAdoptionBookWord(dtSelectedRows, true)).Start();

                MessageBox.Show(MessageUser.DocumentCreateSucc, MessageUser.TitleLibrary, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListBook.ClearSelection();
                dgvListBook.CurrentCell = null;
            }
            else
            {
                MessageBox.Show(MessageUser.NeedSelectRow, MessageUser.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateWordExceptionBook_Click(object sender, EventArgs e)   //клик по кнопке формирование акта об исключении в формате docx
        {
            selectedCellCount = dgvListBook.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                ActExceptionBookWord actExceptionBookWord = new ActExceptionBookWord();
                CreateTableSelectedExceptionRows();

                new Thread(() => actExceptionBookWord.CreateActExceptionBookWord(dtSelectedExceptionRows, false)).Start();

                MessageBox.Show(MessageUser.DocumentCreateSucc, MessageUser.TitleLibrary, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListBook.ClearSelection();
                dgvListBook.CurrentCell = null;
                selectedCellCount = 0;
            }
            else
            {
                MessageBox.Show(MessageUser.NeedSelectRow, MessageUser.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateTableSelectedExceptionRows() //запоминание выбранных записей для акта об исключении
        {
            dtSelectedExceptionRows.Clear();

            for (int i = 0; i < dgvListBook.RowCount; i++)
            {
                for (int j = 0; j < dgvListBook.ColumnCount; j++)
                {
                    if (dgvListBook.Rows[i].Cells[j].Selected == true)
                    {
                        dtSelectedExceptionRows.Rows.Add(dgvListBook.Rows[i].Cells[0].Value.ToString(), dgvListBook.Rows[i].Cells[1].Value.ToString(),
                            dgvListBook.Rows[i].Cells[2].Value.ToString(), dgvListBook.Rows[i].Cells[3].Value.ToString(), dgvListBook.Rows[i].Cells[4].Value.ToString());
                        break;
                    }
                }
            }
        }

        private void btnCreatePdfExceptionBook_Click(object sender, EventArgs e)    //клик по кнопке формирование акта об исключении в формате docx
        {
            selectedCellCount = dgvListBook.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                ActExceptionBookWord actExceptionBookWord = new ActExceptionBookWord();
                CreateTableSelectedExceptionRows();

                new Thread(() => actExceptionBookWord.CreateActExceptionBookWord(dtSelectedExceptionRows, true)).Start();

                MessageBox.Show(MessageUser.DocumentCreateSucc, MessageUser.TitleLibrary, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListBook.ClearSelection();
                dgvListBook.CurrentCell = null;
                selectedCellCount = 0;
            }
            else
            {
                MessageBox.Show(MessageUser.NeedSelectRow, MessageUser.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RegistryData.ErrorMessage, MessageUser.TitleError);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
