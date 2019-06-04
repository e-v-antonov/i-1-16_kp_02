using System;
using System.Threading;
using System.Windows.Forms;

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

        private void документToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RegistrationCardWord registrationCardWord = new RegistrationCardWord();
            //registrationCardWord.CreateDoc();

            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.Show(this);

            //Form1 form1 = new Form1();
            //form1.Show(this);
        }

        private void miPost_Click(object sender, EventArgs e)
        {
            PostForm postForm = new PostForm();
            postForm.Show();
        }

        private void miUsers_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }
    }
}
