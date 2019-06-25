using System;
using System.Threading;
using System.Windows.Forms;
using static Library.Program;

namespace Library
{
    public partial class MainMenuForm : Form
    {
        private DBConnection dbConnection = new DBConnection();
        private RegistryData registryData = new RegistryData();
        private Thread threadCheckConnection;

        public MainMenuForm()
        {
            InitializeComponent();           
            EnableComponent.EventHandler = new EnableComponent.MyEvent(EnableMenu);
        }       

        public void MainMenu_Load(object sender, EventArgs e)   //загрузка формы
        {
            lbsstConnection.Visible = true;
            lbsstConnection.Text = MessageUser.SearchserverMenu;
            dbConnection.ConnectionState += InformationConnection;
            threadCheckConnection = new Thread(dbConnection.CheckConnection);
            threadCheckConnection.Start();
        }


        private void EnableMenu(int userRole)    //доступность меню
        {
            switch (userRole)
            {
                case 1:
                    miHandbook.Enabled = true;
                    miRegistrationCardReader.Enabled = true;
                    miBooks.Enabled = true;
                    miFormulars.Enabled = true;
                    miGenreBook.Enabled = true;
                    miPublishingBook.Enabled = true;
                    miWriterBook.Enabled = true;
                    miUsers.Enabled = true;
                    miExitProfile.Enabled = true;
                    miSettings.Enabled = true;
                    miSettingApplication.Enabled = true;
                    miSettingConnection.Enabled = true;
                    miAuthorization.Enabled = false;
                    break;

                case 2:
                    miHandbook.Enabled = true;
                    miRegistrationCardReader.Enabled = true;
                    miBooks.Enabled = true;
                    miExitProfile.Enabled = true;
                    miAuthorization.Enabled = false;
                    break;

                case 3:
                    miHandbook.Enabled = true;
                    miRegistrationCardReader.Enabled = true;
                    miBooks.Enabled = true;
                    miDocument.Enabled = true;
                    miCreateActs.Enabled = true;
                    miExitProfile.Enabled = true;
                    miSettings.Enabled = true;
                    miSettingApplication.Enabled = true;
                    miAuthorization.Enabled = false;
                    break;

                case 4:
                    miHandbook.Enabled = true;
                    miRegistrationCardReader.Enabled = true;
                    miBooks.Enabled = true;                
                    miGenreBook.Enabled = true;
                    miPublishingBook.Enabled = true;
                    miWriterBook.Enabled = true;
                    miDocument.Enabled = true;
                    miCreateInventoryBook.Enabled = true;
                    miCreateSummaryBook.Enabled = true;
                    miExitProfile.Enabled = true;
                    miSettings.Enabled = true;
                    miSettingApplication.Enabled = true;
                    miAuthorization.Enabled = false;
                    break;

                case 5:
                    miHandbook.Enabled = true;
                    miRegistrationCardReader.Enabled = true;
                    miBooks.Enabled = true;
                    miFormulars.Enabled = true;
                    miIssueBook.Enabled = true;
                    miReturnBook.Enabled = true;
                    miDocument.Enabled = true;
                    miCreatedRegistrationCardAndFormular.Enabled = true;
                    miExitProfile.Enabled = true;
                    miSettings.Enabled = true;
                    miSettingApplication.Enabled = true;
                    miAuthorization.Enabled = false;
                    break;
            }
        }

        private void InformationConnection(bool value)  //проверка подключения к базе данных
        {
            try
            {
                Action action = () =>
                {
                    switch (value)
                    {
                        case (true):
                            lbsstConnection.Text = RegistryData.DataSourceIP + "\\" + RegistryData.DataSourceServerName + " - " + RegistryData.InitialCatalog;
                            AuthorizationForm authorizationForm = new AuthorizationForm();
                            authorizationForm.Show(this);
                            break;
                        case (false):
                            lbsstConnection.Text = MessageUser.NoConnection;

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "ConnectionForm")
                                    return;
                            }

                            ConnectionForm connectionForm = new ConnectionForm();                            
                            connectionForm.Show(this);
                            break;
                    }
                };
                Invoke(action);
            }
            catch
            {
                threadCheckConnection.Abort();
            }
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)    //закрытие формы
        {
            Application.Exit();
        }

        private void miGenreBook_Click(object sender, EventArgs e)  //открытие справочника Жанры
        {
            GenreBookForm genreBookForm = new GenreBookForm();            
            genreBookForm.Show(this);
        }

        private void miPublishingBook_Click(object sender, EventArgs e) //открытие справочника Издательства
        {
            PublishingBookForm publishingBookForm = new PublishingBookForm();
            publishingBookForm.Show();
        }

        private void miWriterBook_Click(object sender, EventArgs e) //открытие справочника Авторы
        {
            WriterBookForm writerBookForm = new WriterBookForm();
            writerBookForm.Show(this);
        }
        
        private void miRegistrationCardReader_Click(object sender, EventArgs e) //открытие справочника Регистрационная карточка
        {
            RegistrationCardForm registrationCardForm = new RegistrationCardForm();
            switch (AuthorizationForm.userRole)
            {
                case 1:
                    registrationCardForm.btnInsert.Enabled = true;
                    registrationCardForm.btnUpdate.Enabled = true;
                    registrationCardForm.btnDelete.Enabled = true;
                    break;
                case 5:
                    registrationCardForm.btnInsert.Enabled = true;
                    registrationCardForm.btnUpdate.Enabled = true;
                    registrationCardForm.btnDelete.Enabled = true;
                    break;
            }
            registrationCardForm.Show(this);
        }

        private void miBooks_Click(object sender, EventArgs e)  //открытие справочника Книги
        {
            BookForm bookForm = new BookForm();
            switch (AuthorizationForm.userRole)
            {
                case 1:
                    bookForm.btnInsert.Enabled = true;
                    bookForm.btnUpdate.Enabled = true;
                    bookForm.btnDelete.Enabled = true;
                    bookForm.btnUpdateGenre.Enabled = true;
                    bookForm.btnUpdatePublishing.Enabled = true;
                    bookForm.btnUpdateWriter.Enabled = true;
                    break;
                case 4:
                    bookForm.btnInsert.Enabled = true;
                    bookForm.btnUpdate.Enabled = true;
                    bookForm.btnDelete.Enabled = true;
                    bookForm.btnUpdateGenre.Enabled = true;
                    bookForm.btnUpdatePublishing.Enabled = true;
                    bookForm.btnUpdateWriter.Enabled = true;
                    break;
            }
            bookForm.Show(this);
        }

        private void miFormulars_Click(object sender, EventArgs e)  //открытие справочника Формуляры
        {
            FormularForm formularForm = new FormularForm();
            formularForm.Show(this);
        }

        private void miUsers_Click(object sender, EventArgs e)  //открытие справочника Пользователи
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void miIssueBook_Click(object sender, EventArgs e)  //открытие окна выдачи книги
        {
            IssueBookForm issueBookForm = new IssueBookForm();
            issueBookForm.Show(this);
        }

        private void miReturnBook_Click(object sender, EventArgs e) //открытие окна возврата книги
        {
            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.Show(this);
        }

        private void miExitSystem_Click(object sender, EventArgs e) //выход из ИС
        {
            Application.Exit();
        }

        private void miExitProfile_Click(object sender, EventArgs e)    //выход из профиля
        {
            switch (AuthorizationForm.userRole)
            {
                case 1:
                    miHandbook.Enabled = false;
                    miRegistrationCardReader.Enabled = false;
                    miBooks.Enabled = false;
                    miFormulars.Enabled = false;
                    miGenreBook.Enabled = false;
                    miPublishingBook.Enabled = false;
                    miWriterBook.Enabled = false;
                    miUsers.Enabled = false;
                    miExitProfile.Enabled = false;
                    miSettings.Enabled = false;
                    miSettings.Enabled = false;
                    miSettingApplication.Enabled = false;
                    miSettingConnection.Enabled = false;
                    miAuthorization.Enabled = true;
                    break;

                case 2:
                    miHandbook.Enabled = false;
                    miRegistrationCardReader.Enabled = false;
                    miBooks.Enabled = false;
                    miExitProfile.Enabled = false;
                    miSettings.Enabled = false;
                    miAuthorization.Enabled = true;
                    break;

                case 3:
                    miHandbook.Enabled = false;
                    miRegistrationCardReader.Enabled = false;
                    miBooks.Enabled = false;
                    miDocument.Enabled = false;
                    miCreateActs.Enabled = false;
                    miExitProfile.Enabled = false;
                    miSettings.Enabled = false;
                    miSettingApplication.Enabled = false;
                    miAuthorization.Enabled = true;
                    break;

                case 4:
                    miHandbook.Enabled = false;
                    miRegistrationCardReader.Enabled = false;
                    miBooks.Enabled = false;
                    miFormulars.Enabled = false;
                    miGenreBook.Enabled = false;
                    miPublishingBook.Enabled = false;
                    miWriterBook.Enabled = false;
                    miDocument.Enabled = false;
                    miCreateInventoryBook.Enabled = false;
                    miCreateSummaryBook.Enabled = false;
                    miExitProfile.Enabled = false;
                    miSettings.Enabled = false;
                    miSettingApplication.Enabled = false;
                    miAuthorization.Enabled = true;
                    break;

                case 5:
                    miHandbook.Enabled = false;
                    miRegistrationCardReader.Enabled = false;
                    miBooks.Enabled = false;
                    miFormulars.Enabled = false;
                    miIssueBook.Enabled = false;
                    miReturnBook.Enabled = false;
                    miDocument.Enabled = false;
                    miCreatedRegistrationCardAndFormular.Enabled = false;
                    miExitProfile.Enabled = false;
                    miSettings.Enabled = false;
                    miSettingApplication.Enabled = false;
                    miAuthorization.Enabled = true;
                    break;
            }
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show(this);
            AuthorizationForm.userRole = 0;
        }

        private void miCreatedRegistrationCardAndFormular_Click(object sender, EventArgs e) //открытие формы для формирования документов формуляров и рег. карточки
        {
            FormationCardAndFormularForm formationCardAndFormularForm = new FormationCardAndFormularForm();
            formationCardAndFormularForm.Show(this);
        }

        private void miCreateActs_Click(object sender, EventArgs e) //открытия форма для формирования документов актов
        {
            FormationActsForm formationActsForm = new FormationActsForm();
            formationActsForm.Show(this);
        }

        private void miCreateInventoryBook_Click(object sender, EventArgs e)    //формирование документа Инвентарная книга
        {
            InventoryBookExcel inventoryBookExcel = new InventoryBookExcel();
            Thread threadInventoryBookExcel = new Thread(inventoryBookExcel.InventoryBookFill);
            threadInventoryBookExcel.Start();
        }

        private void miCreateSummaryBook_Click(object sender, EventArgs e)  //формирования документа Книга суммарного учета
        {
            SummaryBookExcel summaryBookExcel = new SummaryBookExcel();
            Thread threadSummaryBookExcel = new Thread(summaryBookExcel.SummaryBookFill);
            threadSummaryBookExcel.Start();
        }

        private void miAuthorization_Click(object sender, EventArgs e)  //открытие окна авторизации
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show(this);
        }

        private void miSettingApplication_Click(object sender, EventArgs e) //открытие окна настройки приложения
        {
            SettingsApplication settingsApplication = new SettingsApplication();
            settingsApplication.Show(this);
        }

        private void miSettingConnection_Click(object sender, EventArgs e)  //открытие окна настройки подключения к БД
        {
            ConnectionForm connectionFormOpen = new ConnectionForm();
            connectionFormOpen.Show(this);
        }
    }
}
