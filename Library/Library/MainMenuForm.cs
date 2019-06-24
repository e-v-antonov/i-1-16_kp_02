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
            EnableComponent.EventHandler = new EnableComponent.MyEvent(UpdateEnable);
        }       

        public void MainMenu_Load(object sender, EventArgs e)   //загрузка формы
        {
            lbsstConnection.Visible = true;
            lbsstConnection.Text = "Определение сервера...";
            dbConnection.ConnectionState += InformationConnection;
            threadCheckConnection = new Thread(dbConnection.CheckConnection);
            threadCheckConnection.Start();
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
                            lbsstConnection.Text = "Подключение отсутствует!";

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

        private void UpdateEnable(bool valueUpdateEnable)
        {
            miExitProfile.Enabled = valueUpdateEnable;
            miSettings.Enabled = valueUpdateEnable;
            miIssueBook.Enabled = valueUpdateEnable;
            miReturnBook.Enabled = valueUpdateEnable;
            miHandbook.Enabled = valueUpdateEnable;
            miDocument.Enabled = valueUpdateEnable;
        }

        private void miSettings_Click(object sender, EventArgs e)   //открытие окна подключения к базе данных
        {
            ConnectionForm connectionFormOpen = new ConnectionForm();
            connectionFormOpen.Show(this);
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)    //закрытие формы
        {
            Application.Exit();
        }

        private void miGenreBook_Click(object sender, EventArgs e)
        {           
            GenreBookForm genreBookForm = new GenreBookForm();
            genreBookForm.Show(this);
        }

        private void miPublishingBook_Click(object sender, EventArgs e)
        {
            PublishingBookForm publishingBookForm = new PublishingBookForm();
            publishingBookForm.Show();
        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriterBookForm writerBookForm = new WriterBookForm();
            writerBookForm.Show(this);
        }

        private void miRegistrationCardReader_Click(object sender, EventArgs e)
        {
            RegistrationCardForm registrationCardForm = new RegistrationCardForm();
            registrationCardForm.Show(this);
        }

        private void miBooks_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.Show(this);
        }

        private void miFormulars_Click(object sender, EventArgs e)
        {
            FormularForm formularForm = new FormularForm();
            formularForm.Show(this);
        }

        private void miUsers_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void miIssueBook_Click(object sender, EventArgs e)
        {
            IssueBookForm issueBookForm = new IssueBookForm();
            issueBookForm.Show(this);
        }

        private void miReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.Show(this);
        }

        private void miExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miExitProfile_Click(object sender, EventArgs e)
        {
            EnableComponent.EventHandler(false);
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show(this);
            AuthorizationForm.userRole = 0;
        }

        private void miCreatedRegistrationCardAndFormular_Click(object sender, EventArgs e)
        {
            FormationCardAndFormularForm formationCardAndFormularForm = new FormationCardAndFormularForm();
            formationCardAndFormularForm.Show(this);
        }

        private void miCreateActs_Click(object sender, EventArgs e)
        {
            FormationActsForm formationActsForm = new FormationActsForm();
            formationActsForm.Show(this);
        }

        private void miCreateInventoryBook_Click(object sender, EventArgs e)
        {
            InventoryBookExcel inventoryBookExcel = new InventoryBookExcel();
            Thread threadInventoryBookExcel = new Thread(inventoryBookExcel.InventoryBookFill);
            threadInventoryBookExcel.Start();
        }

        private void miCreateSummaryBook_Click(object sender, EventArgs e)
        {
            SummaryBookExcel summaryBookExcel = new SummaryBookExcel();
            Thread threadSummaryBookExcel = new Thread(summaryBookExcel.SummaryBookFill);
            threadSummaryBookExcel.Start();
        }
    }
}
