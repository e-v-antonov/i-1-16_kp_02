using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Library
{
    public partial class IssueBookForm : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private int countReader = 0;
        private SqlCommand commandSearchBook = new SqlCommand("", RegistryData.DBConnectionString);
        private string filterBook = "";
        private DateTime dateIssue;
        private int bookOnReader = 1;
        private string issueBook = "";
        private int idRegistrationCardReader = 0;

        public IssueBookForm()
        {
            InitializeComponent();
        }

        private void btnIdentificationReader_Click(object sender, EventArgs e)  //клик по кнопке идентификации клиента
        {
            SqlCommand command = new SqlCommand("", RegistryData.DBConnectionString);
            command.CommandText = "select count(*) from [dbo].[Registration_Card_Reader_View] where [Surname_Reader] = '" + tbSurname.Text + "' and [Name_Reader] = '" + tbName.Text + "' and [Patronymic_Reader] = '" + tbPatronymic.Text + "' and [Passport_Series_Reader] = '" + tbPassportSeries.Text + "' and [Passport_Number_Reader] = '" + tbPassportNumber.Text + "'";

            try
            {
                RegistryData.DBConnectionString.Open();
                DBTables dbTables = new DBTables();
                dbTables.CommandOpenKey.ExecuteNonQuery();
                countReader = Convert.ToInt32(command.ExecuteScalar().ToString());
                dbTables.CommandCloseKey.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
            }
            finally
            {
                RegistryData.DBConnectionString.Close();
            }

            if (countReader == 0)
            {
                MessageBox.Show(MessageUser.NoReader, MessageUser.TitleLibrary, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSurname.Clear();
                tbName.Clear();
                tbPatronymic.Clear();
                tbPassportSeries.Clear();
                tbPassportNumber.Clear();
            }
            else
            {
                Thread threadBook = new Thread(BookFill);
                Thread threadWriter = new Thread(WriterBookFill);
                Thread threadGenre = new Thread(GenreFill);
                Thread threadPublishing = new Thread(PublishingFill);
                threadBook.Start();
                threadWriter.Start();
                threadGenre.Start();
                threadPublishing.Start();

                dgvBook.Enabled = true;
                tbSurname.Enabled = false;
                tbName.Enabled = false;
                tbPatronymic.Enabled = false;
                tbPassportSeries.Enabled = false;
                tbPassportNumber.Enabled = false;
                btnIdentificationReader.Enabled = false;
                btnRegistrationReader.Enabled = false;
                tbTitleBook.Enabled = true;
                cbWriter.Enabled = true;
                cbGenre.Enabled = true;
                cbPublishing.Enabled = true;
            }

        }

        private void BookFill() //заполнение data grid view данными
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
                    dgvBook.Columns[1].HeaderText = MessageUser.BookTitle;
                    dgvBook.Columns[2].Visible = false;
                    dgvBook.Columns[3].HeaderText = MessageUser.WriterBook;
                    dgvBook.Columns[4].Visible = false;
                    dgvBook.Columns[5].HeaderText = MessageUser.GenreBook;
                    dgvBook.Columns[6].Visible = false;
                    dgvBook.Columns[7].HeaderText = MessageUser.PublishingBook;
                    dgvBook.Columns[8].HeaderText = MessageUser.PublicationDate;
                    dgvBook.Columns[9].HeaderText = MessageUser.NumberOfPages;
                    dgvBook.Columns[10].HeaderText = MessageUser.NumberISBN;
                    dgvBook.Columns[11].HeaderText = MessageUser.TheCostOfInstance;
                    dgvBook.Columns[12].HeaderText = MessageUser.TotalNumberOfInstances;
                    dgvBook.Columns[13].HeaderText = MessageUser.NumberOfInstancesAvailable;
                    dgvBook.Columns[14].HeaderText = MessageUser.DateRistrationBook;
                    dgvBook.ClearSelection();
                    dgvBook.CurrentCell = null;
                }
                catch
                {
                    MessageBox.Show(MessageUser.ErrorLoadingData, MessageUser.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(MessageUser.ErrorLoadingData, MessageUser.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(MessageUser.ErrorLoadingData, MessageUser.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(MessageUser.ErrorLoadingData, MessageUser.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnRegistrationReader_Click(object sender, EventArgs e)    //открытие формы для регистрации читателя
        {
            RegistrationCardForm registrationCardForm = new RegistrationCardForm();
            registrationCardForm.Show(this);
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)  //клик по ячейке
        {
            tbTitleBook.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
            cbWriter.SelectedValue = dgvBook.CurrentRow.Cells[2].Value.ToString();
            cbPublishing.SelectedValue = dgvBook.CurrentRow.Cells[4].Value.ToString();
            cbGenre.SelectedValue = dgvBook.CurrentRow.Cells[6].Value.ToString();

            btnCheckBook.Enabled = false;

            nudNumberDays.Enabled = true;
            btnIssueBook.Enabled = true;

            nudNumberDays_ValueChanged(sender, e);
        }

        private void tbTitleBook_TextChanged(object sender, EventArgs e)    //изменение текста в поле ввода
        {
            if (tbTitleBook.TextLength == 0 && cbWriter.Text == "" && cbGenre.Text == "" && cbPublishing.Text == "")
                btnCheckBook.Enabled = false;
            else
                btnCheckBook.Enabled = true;
        }

        private void btnCheckBook_Click(object sender, EventArgs e) //проверка наличия книги
        {
            BookFill();

            if (cbWriter.Text == "" && cbGenre.Text == "" && cbPublishing.Text == "")   //поиск по названию
                for (int i = 0; i < dgvBook.RowCount; i++)
                {
                        if (dgvBook.Rows[i].Cells[1].Value != null)
                            if (dgvBook.Rows[i].Cells[1].Value.ToString().Contains(tbTitleBook.Text))
                            {
                                dgvBook.Rows[i].Selected = true;
                                dgvBook.CurrentCell = dgvBook.Rows[i].Cells[1];
                                tbTitleBook.Text = dgvBook.Rows[i].Cells[1].Value.ToString();
                                cbWriter.SelectedValue = dgvBook.Rows[i].Cells[2].Value.ToString();
                                cbPublishing.SelectedValue = dgvBook.Rows[i].Cells[4].Value.ToString();
                                cbGenre.SelectedValue = dgvBook.Rows[i].Cells[6].Value.ToString();
                                nudNumberDays.Enabled = true;
                                btnIssueBook.Enabled = true;
                                nudNumberDays_ValueChanged(sender, e);
                                break;
                            }
                            else
                            {
                                if (i == dgvBook.RowCount - 1)
                                    MessageBox.Show(MessageUser.BookNoInLibrary, MessageUser.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                }
            else
                if (tbTitleBook.Text == "" && cbGenre.Text == "" && cbPublishing.Text == "")    //поиск автору
                    for (int i = 0; i < dgvBook.RowCount; i++)
                    {
                        dgvBook.CurrentCell = null;
                        for (int j = 0; j < dgvBook.ColumnCount; j++)
                        {
                            if (dgvBook.Rows[i].Cells[j].Value != null)
                                if (dgvBook.Rows[i].Cells[j].Value.ToString().Contains(cbWriter.Text))
                                {
                                    dgvBook.Rows[i].Selected = true;
                                    break;
                                }
                        }
                    }
                else
                    if (tbTitleBook.Text == "" && cbWriter.Text == "" && cbPublishing.Text == "")   //поиск по жанру
                        for (int i = 0; i < dgvBook.RowCount; i++)
                        {
                            dgvBook.CurrentCell = null;
                            for (int j = 0; j < dgvBook.ColumnCount; j++)
                            {
                                if (dgvBook.Rows[i].Cells[j].Value != null)
                                    if (dgvBook.Rows[i].Cells[j].Value.ToString().Contains(cbGenre.Text))
                                    {
                                        dgvBook.Rows[i].Selected = true;
                                        break;
                                    }
                            }
                        }
                    else
                        if (tbTitleBook.Text == "" && cbWriter.Text == "" && cbGenre.Text == "")    //поиск по издательству
                            for (int i = 0; i < dgvBook.RowCount; i++)
                            {
                                dgvBook.CurrentCell = null;
                                for (int j = 0; j < dgvBook.ColumnCount; j++)
                                {
                                    if (dgvBook.Rows[i].Cells[j].Value != null)
                                        if (dgvBook.Rows[i].Cells[j].Value.ToString().Contains(cbPublishing.Text))
                                        {
                                            dgvBook.Rows[i].Selected = true;
                                            break;
                                        }
                                }
                            }
                        else
                        {
                            tbTitleBook.Clear();
                            cbWriter.SelectedIndex = -1;
                            cbGenre.SelectedIndex = -1;
                            cbPublishing.SelectedIndex = -1;
                            MessageBox.Show(MessageUser.OnlyField, MessageUser.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
        }

        private void cbWriter_TextChanged(object sender, EventArgs e)   //изменение текста в выпадающем списке
        {
            if (cbWriter.Text == "" && cbGenre.Text == "" && cbPublishing.Text == "")
            {
                cbWriter.SelectedIndex = -1;
                btnCheckBook.Enabled = false;
            }
            else
                btnCheckBook.Enabled = true;
        }

        private void cbGenre_TextChanged(object sender, EventArgs e)    //изменение текста в выпадающем списке
        {
            if (cbGenre.Text == "" && cbWriter.Text == "" && cbPublishing.Text == "")
            {
                cbGenre.SelectedIndex = -1;
                btnCheckBook.Enabled = false;
            }
            else
                btnCheckBook.Enabled = true;
        }

        private void cbPublishing_TextChanged(object sender, EventArgs e)   //изменение текста в выпадающем списке
        {
            if (cbPublishing.Text == "" && cbWriter.Text == "" && cbPublishing.Text == "")
            {
                cbPublishing.SelectedIndex = -1;
                btnCheckBook.Enabled = false;
            }
            else
                btnCheckBook.Enabled = true;
        }

        private void nudNumberDays_ValueChanged(object sender, EventArgs e) //изменение текста в выпадающем списке
        {
            dateIssue = dtpDateIssueBook.Value;
            tbDateReturn.Text = dateIssue.AddDays(Convert.ToDouble(nudNumberDays.Value)).ToString("dd.MM.yyyy");
        }

        private void btnIssueBook_Click(object sender, EventArgs e) //клик по кнопке выдать книгу
        {
            SqlCommand commandBookOnHandReader = new SqlCommand("", RegistryData.DBConnectionString);
            SqlCommand commandIDRegistrationCard = new SqlCommand("", RegistryData.DBConnectionString);
            commandBookOnHandReader.CommandText = "select [Book_On_Hand_Reader] from [dbo].[Registration_Card_Reader_View] where [Surname_Reader] = '" + tbSurname.Text + "' and [Name_Reader] = '" + tbName.Text + "' and [Patronymic_Reader] = '" + tbPatronymic.Text + "' and [Passport_Series_Reader] = '" + tbPassportSeries.Text + "' and [Passport_Number_Reader] = '" + tbPassportNumber.Text + "'";
            commandIDRegistrationCard.CommandText = "select [ID_Registration_Card_Reader] from [dbo].[Registration_Card_Reader_View] where [Surname_Reader] = '" + tbSurname.Text + "' and [Name_Reader] = '" + tbName.Text + "' and [Patronymic_Reader] = '" + tbPatronymic.Text + "' and [Passport_Series_Reader] = '" + tbPassportSeries.Text + "' and [Passport_Number_Reader] = '" + tbPassportNumber.Text + "'";

            try
            {
                RegistryData.DBConnectionString.Open();
                DBTables dbTables = new DBTables();
                dbTables.CommandOpenKey.ExecuteNonQuery();
                bookOnReader = Convert.ToInt32(commandBookOnHandReader.ExecuteScalar().ToString());
                idRegistrationCardReader = Convert.ToInt32(commandIDRegistrationCard.ExecuteScalar().ToString());
                dbTables.CommandCloseKey.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
            }
            finally
            {
                RegistryData.DBConnectionString.Close();
            }

            if (bookOnReader == 1)
            {
                MessageBox.Show(MessageUser.ReaderNoReturnedBook, MessageUser.TitleLibrary, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                issueBook = dtpDateIssueBook.Value.ToString("yyyy-MM-dd");

                storedProcedure.SPFormularReaderInsert(issueBook, Convert.ToInt32(nudNumberDays.Value), idRegistrationCardReader, Convert.ToInt32(dgvBook.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show(MessageUser.BookIssue, MessageUser.TitleLibrary, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueBook.Enabled = false;
                nudNumberDays.Enabled = false;
                dgvBook.DataSource = null;
                dgvBook.Enabled = false;
                btnCheckBook.Enabled = false;
                cbGenre.SelectedIndex = -1;
                cbGenre.Enabled = false;
                cbPublishing.Enabled = false;
                cbPublishing.Enabled = false;
                cbWriter.Enabled = false;
                cbWriter.Enabled = false;
                tbTitleBook.Enabled = false;
                tbTitleBook.Clear();
                tbPassportNumber.Enabled = true;
                tbPassportNumber.Clear();
                tbPassportSeries.Enabled = true;
                tbPassportSeries.Clear();
                tbPatronymic.Enabled = true;
                tbPatronymic.Clear();
                tbName.Enabled = true;
                tbName.Clear();
                tbSurname.Enabled = true;
                tbSurname.Clear();
                btnIdentificationReader.Enabled = true;
                btnRegistrationReader.Enabled = true;
            }
        }

        private void btnError_Click(object sender, EventArgs e) //клик по кнопке ошибки
        {
            MessageBox.Show(RegistryData.ErrorMessage, MessageUser.TitleError);
        }

        private void btnExit_Click(object sender, EventArgs e)  //клик по кнопке закрыть
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)    //клик по кнопк отмена
        {
            dgvBook.Enabled = false; ;
            tbSurname.Enabled = true; ;
            tbName.Enabled = true;
            tbPatronymic.Enabled = true;
            tbPassportSeries.Enabled = true;
            tbPassportNumber.Enabled = true;
            btnIdentificationReader.Enabled = true;
            btnRegistrationReader.Enabled = true;
            tbTitleBook.Enabled = false;
            cbWriter.Enabled = false;
            cbGenre.Enabled = false;
            cbPublishing.Enabled = false;
            nudNumberDays.Enabled = false;
            dgvBook.DataSource = null;
            tbTitleBook.Clear();
            cbGenre.SelectedValue = -1;
            cbWriter.SelectedValue = -1;
            cbPublishing.SelectedValue = -1;
        }
    }
}
