using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Library
{
    public partial class RegistrationCardForm : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private SqlCommand commandSearchCard = new SqlCommand("", RegistryData.DBConnectionString);
        private string filterWriterBook = "";
        private string constraintPassportSeries = @"\d{4}";
        private string constraintPassportNumber = @"\d{6}";
        private string symbolConstraint = @"!@#$%^&*()+=/|\<>:;{}[]?`~№";
        private string symbolStreetConstraint = @",";
        private string constraintLetter = @"[^aA-zZ]";
        private string constraintEmail = @"^.+@.+\..+$";
        private bool checkErrorPassportSeries = true;
        private bool checkErrorPassportNumber = true;
        private bool checkErrorWhoGivePassport = true;
        private bool checkErrorTown = true;
        private bool checkErrorStreet = true;
        private bool checkErrorEmail = true;
        private DateTime dateToday = DateTime.Now;
        private string birthday = "";
        private string whenGivePassport = "";
        private string today = "";
        private bool uniquePassport = false;
        private bool uniqueMobilePhone = false;
        private bool uniqueEmail = false;

        public RegistrationCardForm()
        {
            InitializeComponent();
        }

        private void RegistrationCardForm_Load(object sender, EventArgs e)  //загрузка формы
        {
            Thread threadRegistrationCard = new Thread(RegistrationCardFill);
            threadRegistrationCard.Start();
        }

        private void RegistrationCardFill() //заполнение data grid view данными из базы данных
        {
            DBTables dbTables = new DBTables();

            Action action = () =>
            {
                try
                {
                    dbTables.DTRegistrationCard.Clear();
                    dbTables.DTRegistrationCardFill();
                    filterWriterBook = dbTables.QRRegistrationCard;
                    dbTables.dependency.OnChange += ChangeDataRegistrationCard;

                    dgvRegistrationCard.DataSource = dbTables.DTRegistrationCard;
                    dgvRegistrationCard.Columns[0].Visible = false;
                    dgvRegistrationCard.Columns[1].HeaderText = "Фамилия";
                    dgvRegistrationCard.Columns[2].HeaderText = "Имя";
                    dgvRegistrationCard.Columns[3].HeaderText = "Отчество";
                    dgvRegistrationCard.Columns[4].HeaderText = "Дата рождения";
                    dgvRegistrationCard.Columns[5].HeaderText = "Серия паспорта";
                    dgvRegistrationCard.Columns[6].HeaderText = "Номер паспорта";
                    dgvRegistrationCard.Columns[7].HeaderText = "Кем выдан паспорт";
                    dgvRegistrationCard.Columns[8].HeaderText = "Когда выдан паспорт";
                    dgvRegistrationCard.Columns[9].HeaderText = "Город";
                    dgvRegistrationCard.Columns[10].HeaderText = "Улица";
                    dgvRegistrationCard.Columns[11].HeaderText = "Дом";
                    dgvRegistrationCard.Columns[12].HeaderText = "Квартира";
                    dgvRegistrationCard.Columns[13].HeaderText = "Номер мобильного телефона";
                    dgvRegistrationCard.Columns[14].HeaderText = "Номер домашнего телефона";
                    dgvRegistrationCard.Columns[15].HeaderText = "Адрес электронной почты";
                    dgvRegistrationCard.Columns[16].HeaderText = "Наличие книги";
                    dgvRegistrationCard.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("Ошибка загрузки данных из базы данных!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }

        private void ChangeDataRegistrationCard(object sender, SqlNotificationEventArgs e)  //отслеживание изменения в базе данных
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                //e = null;
                RegistrationCardFill();
            }
        }

        private void dgvRegistrationCard_CellClick(object sender, DataGridViewCellEventArgs e)  //клик по полю data grid view
        {
            tbSurname.Text = dgvRegistrationCard.CurrentRow.Cells[1].Value.ToString();
            tbName.Text = dgvRegistrationCard.CurrentRow.Cells[2].Value.ToString();
            tbPatronymic.Text = dgvRegistrationCard.CurrentRow.Cells[3].Value.ToString();
            dtpBirthday.Value = Convert.ToDateTime(dgvRegistrationCard.CurrentRow.Cells[4].Value.ToString());
            tbPassportSeries.Text = dgvRegistrationCard.CurrentRow.Cells[5].Value.ToString();
            tbPassportNumber.Text = dgvRegistrationCard.CurrentRow.Cells[6].Value.ToString();
            tbWhoGivePassport.Text = dgvRegistrationCard.CurrentRow.Cells[7].Value.ToString();
            dtpWhenGivePassport.Value = Convert.ToDateTime(dgvRegistrationCard.CurrentRow.Cells[8].Value.ToString());
            tbTown.Text = dgvRegistrationCard.CurrentRow.Cells[9].Value.ToString();
            tbStreet.Text = dgvRegistrationCard.CurrentRow.Cells[10].Value.ToString();
            tbBuilding.Text = dgvRegistrationCard.CurrentRow.Cells[11].Value.ToString();
            tbApartment.Text = dgvRegistrationCard.CurrentRow.Cells[12].Value.ToString();
            mtbMobilePhone.Text = dgvRegistrationCard.CurrentRow.Cells[13].Value.ToString();
            mtbHomePhone.Text = dgvRegistrationCard.CurrentRow.Cells[14].Value.ToString();
            tbEmail.Text = dgvRegistrationCard.CurrentRow.Cells[15].Value.ToString();

            if (dgvRegistrationCard.CurrentRow.Cells[16].Value.ToString() == "1")
                lbHaveBook.Text = "Наличие книги в данный момент: Да";
            else
                lbHaveBook.Text = "Наличие книги в данный момент: Нет";
        }

        private bool CheckPassportSeries()  //функция проверки серии паспорта
        {
            checkErrorPassportSeries = Regex.IsMatch(tbPassportSeries.Text, constraintPassportSeries, RegexOptions.None) ? false : true;

            return checkErrorPassportSeries;
        }

        private bool CheckPassportNumber()  //функция проверки номера паспорта
        {
            checkErrorPassportNumber = Regex.IsMatch(tbPassportNumber.Text, constraintPassportNumber, RegexOptions.None) ? false : true;

            return checkErrorPassportNumber;
        }

        private bool CheckWhoGivePassport() //функция проверки названия кто выдал паспорт
        {
            if (tbWhoGivePassport.TextLength >= 5 || tbWhoGivePassport.TextLength <= 100)
                if (Regex.IsMatch(tbWhoGivePassport.Text, constraintLetter, RegexOptions.None))
                    checkErrorWhoGivePassport = tbWhoGivePassport.Text.Contains(symbolConstraint);
                else
                    checkErrorWhoGivePassport = true;
            else
                checkErrorWhoGivePassport = true;

            return checkErrorWhoGivePassport;
        }

        private bool CheckTown()    //функция проверки названия города
        {
            if (Regex.IsMatch(tbTown.Text, constraintLetter, RegexOptions.None))
                if (tbTown.Text.Contains(symbolConstraint) == false)
                    checkErrorTown = tbTown.Text.Contains(symbolStreetConstraint);
                else
                    checkErrorTown = true;
            else
                checkErrorTown = true;

            return checkErrorTown;
        }

        private bool CheckStreet()  //функция проверки названия улицы
        {
            if (tbStreet.TextLength >= 2 || tbStreet.TextLength <= 50)
                if (Regex.IsMatch(tbStreet.Text, constraintLetter, RegexOptions.None))
                    if (tbStreet.Text.Contains(symbolConstraint) == false)
                        checkErrorStreet = tbStreet.Text.Contains(symbolStreetConstraint);
                    else
                        checkErrorStreet = true;
                else
                    checkErrorStreet = true;
            else
                checkErrorStreet = true;

            return checkErrorStreet;
        }

        private bool CheckEmail()   //функция проверки email
        {          
            if (tbEmail.TextLength >= 5 || tbEmail.TextLength <= 129)
                checkErrorEmail = Regex.IsMatch(tbEmail.Text, constraintEmail, RegexOptions.None) ? false : true;
            else
                checkErrorEmail = true;

            return checkErrorEmail;
        }

        private bool UniquePassportSeiesNumber(Button button)    //проверка уникальности комбинации серии и номера паспорта
        {
            int currentRow = 0;

            if (button.Name == "btnUpdate")
                currentRow = Convert.ToInt32(dgvRegistrationCard.CurrentRow.Cells[0].Value.ToString());
            else
                currentRow = -1;

            for (int i = 0; i < dgvRegistrationCard.RowCount; i++)
            {
                if (i + 1 == currentRow)
                    continue;
                else
                    if ((tbPassportSeries.Text + tbPassportNumber.Text) == (dgvRegistrationCard.Rows[i].Cells[5].Value.ToString() + dgvRegistrationCard.Rows[i].Cells[6].Value.ToString()))
                    {
                        uniquePassport = false;
                        return uniquePassport;
                    }
                    else
                        uniquePassport = true;
            }

            return uniquePassport;
        }

        private bool UniqueMobile(Button button) //проверка уникальности номера мобильного телефона
        {
            int currentRow = 0;

            if (button.Name == "btnUpdate")
                currentRow = Convert.ToInt32(dgvRegistrationCard.CurrentRow.Cells[0].Value.ToString());
            else
                currentRow = -1;

            for (int i = 0; i < dgvRegistrationCard.RowCount; i++)
            {
                if (i + 1 == currentRow)
                    continue;
                else
                    if (mtbMobilePhone.Text == dgvRegistrationCard.Rows[i].Cells[13].Value.ToString())
                    {
                        uniqueMobilePhone = false;
                        return uniqueMobilePhone;
                    }
                    else
                        uniqueMobilePhone = true;
            }

            return uniqueMobilePhone;
        }

        private bool UniqueEmailAddress(Button button)   //проверка уникальности адреса электронной почты
        {
            int currentRow = 0;

            if (button.Name == "btnUpdate")
                currentRow = Convert.ToInt32(dgvRegistrationCard.CurrentRow.Cells[0].Value.ToString());
            else
                currentRow = -1;

            for (int i = 0; i < dgvRegistrationCard.RowCount; i++)
            {
                if (i + 1 == currentRow)
                    continue;
                else
                    if (tbEmail.Text == dgvRegistrationCard.Rows[i].Cells[15].Value.ToString())
                    {
                        uniqueEmail = false;
                        return uniqueEmail;
                    }
                    else
                        uniqueEmail = true;
            }

            return uniqueEmail;
        }

        private void btnInsert_Click(object sender, EventArgs e)  //кнопка добавления записи
        {
            var nameButton = sender as Button;

            try   //конвертация дат
            {
                birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");
                whenGivePassport = dtpWhenGivePassport.Value.ToString("yyyy-MM-dd");
                dateToday = DateTime.Now;
                today = dateToday.Date.ToString("yyyy-MM-dd");
            }
            catch
            {
                MessageBox.Show("Введите правильные даты!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (CheckPassportSeries() == false && CheckPassportNumber() == false && CheckWhoGivePassport() == false && CheckTown() == false && CheckStreet() == false && CheckEmail() == false && UniquePassportSeiesNumber(nameButton) == true && UniqueMobile(nameButton) == true && UniqueEmailAddress(nameButton) == true)
                try
                {
                    storedProcedure.SPRegistrationCardReaderInsert(tbSurname.Text, tbName.Text, tbPatronymic.Text, birthday,
                    tbPassportSeries.Text, tbPassportNumber.Text, tbWhoGivePassport.Text, whenGivePassport, tbTown.Text, tbStreet.Text,
                    Convert.ToInt32(tbBuilding.Text), Convert.ToInt32(tbApartment.Text), mtbHomePhone.Text, mtbMobilePhone.Text, tbEmail.Text, today);
                }
                catch
                {
                    RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + " Поля Дом и Квартира должны быть заполнены целыми числами! Проверьте правильность ввода данных!";
                }
            else
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + "Проверьте правильность ввода данных! Поля Серия паспорта и " +
                    "Номер паспорта должны содержать 4 и 6 цифр соответственно.\n Поля Кем выдан паспорт, Город, Улица не должны содержать других " +
                    "знаков кроме русских букв, цифр, точки, и дефиса.\n Поле адрес электронной почты обязательно должен содержать знак @ и точку после него.\n " +
                    "Комбинация серии и номера паспорта, а также номер мобильного телефона и адрес электронной почты должны быть уникальными по отношению к данным в базе данных.";

            tbSurname.Clear();
            tbName.Clear();
            tbPatronymic.Clear();
            dtpBirthday.Value = DateTime.Now;
            tbPassportSeries.Clear();
            tbPassportNumber.Clear();
            tbWhoGivePassport.Clear();
            dtpWhenGivePassport.Value = DateTime.Now;
            tbTown.Clear();
            tbStreet.Clear();
            tbBuilding.Clear();
            tbApartment.Clear();
            mtbHomePhone.Clear();
            mtbMobilePhone.Clear();
            tbEmail.Clear();
            dgvRegistrationCard.ClearSelection();
            RegistrationCardFill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)    //кнопка изменения записи
        {
            var nameButton = sender as Button;

            try  //конвертация дат
            {
                birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");
                whenGivePassport = dtpWhenGivePassport.Value.ToString("yyyy-MM-dd");
                dateToday = DateTime.Now;
                today = dateToday.Date.ToString("yyyy-MM-dd");
            }
            catch
            {
                MessageBox.Show("Введите правильные даты!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (CheckPassportSeries() == false && CheckPassportNumber() == false && CheckWhoGivePassport() == false && CheckTown() == false && CheckStreet() == false && CheckEmail() == false && UniquePassportSeiesNumber(nameButton) == true && UniqueMobile(nameButton) == true && UniqueEmailAddress(nameButton) == true)
                try
                {
                    storedProcedure.SPRegistrationCardReaderUpdate(Convert.ToInt32(dgvRegistrationCard.CurrentRow.Cells[0].Value.ToString()), tbSurname.Text, tbName.Text, tbPatronymic.Text, birthday,
                    tbPassportSeries.Text, tbPassportNumber.Text, tbWhoGivePassport.Text, whenGivePassport, tbTown.Text, tbStreet.Text,
                    Convert.ToInt32(tbBuilding.Text), Convert.ToInt32(tbApartment.Text), mtbHomePhone.Text, mtbMobilePhone.Text, tbEmail.Text);
                }
                catch
                {
                    RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + " Поля Дом и Квартира должны быть заполнены числами! Проверьте правильность ввода данных!";
                }
            else
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + "Проверьте правильность ввода данных! Поля Серия паспорта и " +
                    "Номер паспорта должны содержать 4 и 6 цифр соответственно.\n Поля Кем выдан паспорт, Город, Улица не должны содержать других " +
                    "знаков кроме русских букв, цифр, точки, и дефиса.\n Поле адрес электронной почты обязательно должен содержать знак @ и точку после него.";

            tbSurname.Clear();
            tbName.Clear();
            tbPatronymic.Clear();
            dtpBirthday.Value = DateTime.Now;
            tbPassportSeries.Clear();
            tbPassportNumber.Clear();
            tbWhoGivePassport.Clear();
            dtpWhenGivePassport.Value = DateTime.Now;
            tbTown.Clear();
            tbStreet.Clear();
            tbBuilding.Clear();
            tbApartment.Clear();
            mtbHomePhone.Clear();
            mtbMobilePhone.Clear();
            tbEmail.Clear();
            dgvRegistrationCard.ClearSelection();
            RegistrationCardFill();
        }

        private void btnDelete_Click(object sender, EventArgs e)    //кнопка удаления записи
        {
            switch (MessageBox.Show("Удалить регистрационную карточку " + tbSurname.Text + " " + tbName.Text + " " + tbPatronymic.Text + "?", "Удаление регистрационной карточки", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    storedProcedure.SPRegistrationCardReaderDelete(Convert.ToInt32(dgvRegistrationCard.CurrentRow.Cells[0].Value.ToString()));
                    tbSurname.Clear();
                    tbName.Clear();
                    tbPatronymic.Clear();
                    dtpBirthday.Value = DateTime.Now;
                    tbPassportSeries.Clear();
                    tbPassportNumber.Clear();
                    tbWhoGivePassport.Clear();
                    dtpWhenGivePassport.Value = DateTime.Now;
                    tbTown.Clear();
                    tbStreet.Clear();
                    tbBuilding.Clear();
                    tbApartment.Clear();
                    mtbHomePhone.Clear();
                    mtbMobilePhone.Clear();
                    tbEmail.Clear();
                    dgvRegistrationCard.ClearSelection();
                    RegistrationCardFill();
                    break;
            }
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

        private void tbSearch_Click(object sender, EventArgs e) //клик по полю поиска
        {
            tbSearch.Clear();
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
                    DataTable data = new DataTable("Registration_Card_Reader");
                    commandSearchCard.CommandText = filterWriterBook + "and [Surname_Reader] like '%" +
                        tbSearch.Text + "%' or [Name_Reader] like '%" + tbSearch.Text + "%' or [Patronymic_Reader] like '%" +
                        tbSearch.Text + "%' or CONVERT([varchar] (10), [dbo].[Registration_Card_Reader].[Birthday_Reader], 104) like '%" + tbSearch.Text + "%' or CONVERT([nvarchar] (4), DECRYPTBYKEY([dbo].[Registration_Card_Reader].[Passport_Series_Reader])) like '%" +
                        tbSearch.Text + "%' or CONVERT([nvarchar] (6), DECRYPTBYKEY([dbo].[Registration_Card_Reader].[Passport_Number_Reader])) like '%" + tbSearch.Text + "%' or [Who_Give_Passport_Reader] like '%"
                        + tbSearch.Text + "%' or CONVERT([varchar] (10), [dbo].[Registration_Card_Reader].[When_Give_Passport_Reader], 104) like '%" + tbSearch.Text + "%' or [Town_Reader] like '%" +
                        tbSearch.Text + "%' or CONVERT([nvarchar] (50), DECRYPTBYKEY([dbo].[Registration_Card_Reader].[Street_Reader])) like '%" + tbSearch.Text + "%' or [Building_Reader] like '%" + tbSearch.Text
                        + "%' or [Apartment_Reader] like '%" + tbSearch.Text + "%' or CONVERT([nvarchar] (15), DECRYPTBYKEY([dbo].[Registration_Card_Reader].[Home_Phone_Reader])) like '%" + tbSearch.Text +
                        "%' or CONVERT([nvarchar] (15), DECRYPTBYKEY([dbo].[Registration_Card_Reader].[Mobile_Phone_Reader])) like '%" + tbSearch.Text + "%' or CONVERT([nvarchar] (129), DECRYPTBYKEY([dbo].[Registration_Card_Reader].[Email_Reader])) like '%" + tbSearch.Text +
                        "%' or [Book_On_Hand_Reader] like '%" + tbSearch.Text + "%'";
                    RegistryData.DBConnectionString.Open();
                    DBTables dbTables = new DBTables();
                    dbTables.CommandOpenKey.ExecuteNonQuery();
                    data.Load(commandSearchCard.ExecuteReader());
                    dbTables.CommandCloseKey.ExecuteNonQuery();
                    RegistryData.DBConnectionString.Close();

                    dgvRegistrationCard.DataSource = data;
                    dgvRegistrationCard.Columns[0].Visible = false;
                    dgvRegistrationCard.Columns[1].HeaderText = "Фамилия";
                    dgvRegistrationCard.Columns[2].HeaderText = "Имя";
                    dgvRegistrationCard.Columns[3].HeaderText = "Отчество";
                    dgvRegistrationCard.Columns[4].HeaderText = "Дата рождения";
                    dgvRegistrationCard.Columns[5].HeaderText = "Серия паспорта";
                    dgvRegistrationCard.Columns[6].HeaderText = "Номер паспорта";
                    dgvRegistrationCard.Columns[7].HeaderText = "Кем выдан паспорт";
                    dgvRegistrationCard.Columns[8].HeaderText = "Когда выдан паспорт";
                    dgvRegistrationCard.Columns[9].HeaderText = "Город";
                    dgvRegistrationCard.Columns[10].HeaderText = "Улица";
                    dgvRegistrationCard.Columns[11].HeaderText = "Дом";
                    dgvRegistrationCard.Columns[12].HeaderText = "Квартира";
                    dgvRegistrationCard.Columns[13].HeaderText = "Номер мобильного телефона";
                    dgvRegistrationCard.Columns[14].HeaderText = "Номер домашнего телефона";
                    dgvRegistrationCard.Columns[15].HeaderText = "Адрес электронной почты";
                    dgvRegistrationCard.Columns[16].HeaderText = "Наличие книги";
                    dgvRegistrationCard.ClearSelection();
                    break;

                case (CheckState.Unchecked):    //поиск
                    RegistrationCardFill();

                    for (int i = 0; i < dgvRegistrationCard.RowCount; i++)
                    {
                        for (int j = 0; j < dgvRegistrationCard.ColumnCount; j++)
                        {
                            if (dgvRegistrationCard.Rows[i].Cells[j].Value != null)
                                if (dgvRegistrationCard.Rows[i].Cells[j].Value.ToString().Contains(tbSearch.Text))
                                {
                                    dgvRegistrationCard.Rows[i].Selected = true;
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

        private void btnExit_Click(object sender, EventArgs e)  //кнопка закрыть
        {
            Close();
        }

        private void dgvRegistrationCard_Click(object sender, EventArgs e)  //клик по data grid view
        {
            RegistrationCardFill();
        }
    }
}
