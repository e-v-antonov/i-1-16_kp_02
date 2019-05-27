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

        public void MainMenu_Load(object sender, EventArgs e)
        {
            lbsstConnection.Visible = true;
            lbsstConnection.Text = "Определение сервера...";
            dbConnection.ConnectionState += InformationConnection;
            threadCheckConnection = new Thread(dbConnection.CheckConnection);
            threadCheckConnection.Start();
        }

        private void InformationConnection(bool value)
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

        private void miSettings_Click(object sender, EventArgs e)
        {
            ConnectionForm connectionFormOpen = new ConnectionForm();
            connectionFormOpen.Show(this);
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
