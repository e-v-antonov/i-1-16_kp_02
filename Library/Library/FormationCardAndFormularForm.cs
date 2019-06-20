using System;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class FormationCardAndFormularForm : Form
    {
        private string registrationNumber;
        private string dateRegistration;
        private string surname;
        private string name;
        private string patronymic;
        private string birthday;
        private string passportSeries;
        private string passportNumber;
        private string whoGivePassport;
        private string whenGivePassport;
        private string town;
        private string street;
        private string building;
        private string apartment;
        private string mobilePhone;
        private string homePhone;
        private string email;

        public FormationCardAndFormularForm()
        {
            InitializeComponent();
        }

        private void FormationCardAndFormularForm_Load(object sender, EventArgs e)  //загрузка форма
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
                    dgvRegistrationCard.Columns[14].HeaderText = "Номер мобильного телефона";
                    dgvRegistrationCard.Columns[13].HeaderText = "Номер домашнего телефона";
                    dgvRegistrationCard.Columns[15].HeaderText = "Адрес электронной почты";
                    dgvRegistrationCard.Columns[16].HeaderText = "Наличие книги";
                    dgvRegistrationCard.Columns[17].Visible = false;
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
                RegistrationCardFill();
            }
        }

        private void btnCreateWordRegistrationCard_Click(object sender, EventArgs e)    //клик по кнопке формирование регистрационной карточки в формате docx
        {
            if (dgvRegistrationCard.CurrentRow != null)
            {
                RegistrationCardWord registrationCardWord = new RegistrationCardWord();
                DataStorage();
                new Thread(() => registrationCardWord.CreateRegistrationCard(registrationNumber, dateRegistration, surname, name, patronymic, 
                    birthday, passportSeries, passportNumber, whoGivePassport, whenGivePassport, town, street, building, apartment, 
                    mobilePhone, homePhone, email, false)).Start();
                MessageBox.Show("Документ сформирован успешно.", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Для создания документа необходимо выделить строку!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPdfRegistrationCard_Click(object sender, EventArgs e)   //клик по кнопке формирование регистрационной карточки в формате pdf
        {
            if (dgvRegistrationCard.CurrentRow != null)
            {
                RegistrationCardWord registrationCardWord = new RegistrationCardWord();
                DataStorage();
                new Thread(() => registrationCardWord.CreateRegistrationCard(registrationNumber, dateRegistration, surname, name, patronymic,
                    birthday, passportSeries, passportNumber, whoGivePassport, whenGivePassport, town, street, building, apartment,
                    mobilePhone, homePhone, email, true)).Start();
                MessageBox.Show("Документ сформирован успешно.", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Для создания документа необходимо выделить строку!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataStorage()
        {
            registrationNumber = dgvRegistrationCard.CurrentRow.Cells[0].Value.ToString();
            dateRegistration = dgvRegistrationCard.CurrentRow.Cells[17].Value.ToString();
            surname = dgvRegistrationCard.CurrentRow.Cells[1].Value.ToString();
            name = dgvRegistrationCard.CurrentRow.Cells[2].Value.ToString();
            patronymic = dgvRegistrationCard.CurrentRow.Cells[3].Value.ToString();
            birthday = dgvRegistrationCard.CurrentRow.Cells[4].Value.ToString();
            passportSeries = dgvRegistrationCard.CurrentRow.Cells[5].Value.ToString();
            passportNumber = dgvRegistrationCard.CurrentRow.Cells[6].Value.ToString();
            whoGivePassport = dgvRegistrationCard.CurrentRow.Cells[7].Value.ToString();
            whenGivePassport = dgvRegistrationCard.CurrentRow.Cells[8].Value.ToString();
            town = dgvRegistrationCard.CurrentRow.Cells[9].Value.ToString();
            street = dgvRegistrationCard.CurrentRow.Cells[10].Value.ToString();
            building = dgvRegistrationCard.CurrentRow.Cells[11].Value.ToString();
            apartment = dgvRegistrationCard.CurrentRow.Cells[12].Value.ToString();
            mobilePhone = dgvRegistrationCard.CurrentRow.Cells[14].Value.ToString();
            homePhone = dgvRegistrationCard.CurrentRow.Cells[13].Value.ToString();
            email = dgvRegistrationCard.CurrentRow.Cells[15].Value.ToString();
        }
    }
}
