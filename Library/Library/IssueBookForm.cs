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

        private void btnIdentificationReader_Click(object sender, EventArgs e)
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
                MessageBox.Show("Читатель с данными параметрами не зарегистрирован в библиотеке.", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BookFill()
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

        private void btnRegistrationReader_Click(object sender, EventArgs e)
        {
            RegistrationCardForm registrationCardForm = new RegistrationCardForm();
            registrationCardForm.Show(this);
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void tbTitleBook_TextChanged(object sender, EventArgs e)
        {
            if (tbTitleBook.TextLength == 0 && cbWriter.Text == "" && cbGenre.Text == "" && cbPublishing.Text == "")
                btnCheckBook.Enabled = false;
            else
                btnCheckBook.Enabled = true;
        }

        private void btnCheckBook_Click(object sender, EventArgs e)
        {
            BookFill();

            if (cbWriter.Text == "" && cbGenre.Text == "" && cbPublishing.Text == "")
                for (int i = 0; i < dgvBook.RowCount; i++)
                {
                    for (int j = 0; j < dgvBook.ColumnCount; j++)
                    {
                        if (dgvBook.Rows[i].Cells[j].Value != null)
                            if (dgvBook.Rows[i].Cells[j].Value.ToString().Contains(tbTitleBook.Text))
                            {
                                dgvBook.Rows[i].Selected = true;
                                tbTitleBook.Text = dgvBook.Rows[i].Cells[1].Value.ToString();
                                cbWriter.SelectedValue = dgvBook.Rows[i].Cells[2].Value.ToString();
                                cbPublishing.SelectedValue = dgvBook.Rows[i].Cells[4].Value.ToString();
                                cbGenre.SelectedValue = dgvBook.Rows[i].Cells[6].Value.ToString();
                                nudNumberDays.Enabled = true;
                                btnIssueBook.Enabled = true;
                                nudNumberDays_ValueChanged(sender, e);
                                break;
                            }
                    }
                }
            else
                if (tbTitleBook.Text == "" && cbGenre.Text == "" && cbPublishing.Text == "")
                for (int i = 0; i < dgvBook.RowCount; i++)
                {
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
                    if (tbTitleBook.Text == "" && cbWriter.Text == "" && cbPublishing.Text == "")
                for (int i = 0; i < dgvBook.RowCount; i++)
                {
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
                        if (tbTitleBook.Text == "" && cbWriter.Text == "" && cbGenre.Text == "")
                for (int i = 0; i < dgvBook.RowCount; i++)
                {
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
                MessageBox.Show("Должно быть заполнено только одно поле!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbWriter_TextChanged(object sender, EventArgs e)
        {
            if (cbWriter.Text == "" && cbGenre.Text == "" && cbPublishing.Text == "")
            {
                cbWriter.SelectedIndex = -1;
                btnCheckBook.Enabled = false;
            }
            else
                btnCheckBook.Enabled = true;
        }

        private void cbGenre_TextChanged(object sender, EventArgs e)
        {
            if (cbGenre.Text == "" && cbWriter.Text == "" && cbPublishing.Text == "")
            {
                cbGenre.SelectedIndex = -1;
                btnCheckBook.Enabled = false;
            }
            else
                btnCheckBook.Enabled = true;
        }

        private void cbPublishing_TextChanged(object sender, EventArgs e)
        {
            if (cbPublishing.Text == "" && cbWriter.Text == "" && cbPublishing.Text == "")
            {
                cbPublishing.SelectedIndex = -1;
                btnCheckBook.Enabled = false;
            }
            else
                btnCheckBook.Enabled = true;
        }

        private void nudNumberDays_ValueChanged(object sender, EventArgs e)
        {
            dateIssue = dtpDateIssueBook.Value;
            tbDateReturn.Text = dateIssue.AddDays(Convert.ToDouble(nudNumberDays.Value)).ToString("dd.MM.yyyy");
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
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
                MessageBox.Show("Данный читатель еще не вернул выданные ему ранее книги.", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                issueBook = dtpDateIssueBook.Value.ToString("yyyy-MM-dd");

                storedProcedure.SPFormularReaderInsert(issueBook, Convert.ToInt32(nudNumberDays.Value), idRegistrationCardReader, Convert.ToInt32(dgvBook.CurrentRow.Cells[0].Value.ToString()));
                //MessageBox.Show("Книга была успешно выдана читателю.", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnError_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RegistryData.ErrorMessage, "Ошибки в результате работы информационной системы");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
