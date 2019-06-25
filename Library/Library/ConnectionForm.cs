using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Library
{
    public partial class ConnectionForm : Form
    {
        private DBConnection dbConnection = new DBConnection();
        private int status = 1;
        public Thread threadGetServers;
        public Thread threadMessage;        

        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)    //загрузка формы
        {
            switch (DBConnection.LogConnection)
            {
                case (true):
                    cbAddressServer.Text = RegistryData.DataSourceIP;
                    cbNameServer.Text = RegistryData.DataSourceServerName;
                    cbListDataBase.Text = RegistryData.InitialCatalog;
                    cbAddressServer.Enabled = true;
                    cbNameServer.Enabled = true;
                    tbUserServer.Enabled = true;
                    tbPasswordServer.Enabled = true;
                    cbListDataBase.Enabled = true;
                    btnCheck.Enabled = true;
                    break;
                case (false):
                    status = 1;
                    lbsstStatus.Visible = true;
                    lbsstStatus.Text = MessageUser.ServerSearch;
                    dbConnection.DataTableServers += DTServers;
                    threadGetServers = new Thread(dbConnection.GetServers);
                    threadMessage = new Thread(StatusStripMessage);
                    threadMessage.Priority = ThreadPriority.Lowest;
                    threadMessage.IsBackground = true;
                    threadMessage.Start();
                    threadGetServers.Start();
                    break;
            }
        }

        private void DTServers(DataTable table) //загрузка списка серверов
        {
            status = 0;

            try
            {
                Action action = () =>
                {
                    foreach (DataRow r in table.Rows)
                    {
                        cbAddressServer.Items.Add(r[0]);
                        cbNameServer.Items.Add(r[1]);
                    }

                    cbAddressServer.Enabled = true;
                    cbNameServer.Enabled = true;
                    tbUserServer.Enabled = true;
                    tbPasswordServer.Enabled = true;
                    btnCheck.Enabled = true;
                };
                Invoke(action);
            }
            catch
            {
                threadGetServers.Abort();
            }
        }

        private void StatusStripMessage()   //сообщение о статусе подключения
        {
            for (int i = 0; i < status;)
            {
                Thread.Sleep(500);

                try
                {
                    Action action = () =>
                    {
                        switch (status)
                        {
                            case (1):
                                if (lbsstStatus.Text != MessageUser.ServerSearchTochki)
                                    lbsstStatus.Text += ".";
                                else
                                    lbsstStatus.Text = MessageUser.ServerSearch;
                                break;
                            case (2):
                                if (lbsstStatus.Text != MessageUser.DatabaseSearchTochki)
                                    lbsstStatus.Text += ".";
                                else
                                    lbsstStatus.Text = MessageUser.DatabaseSearch;
                                break;
                            case (0):
                                lbsstStatus.Text = "-";
                                lbsstStatus.Visible = false;
                                break;
                        }
                    };
                    Invoke(action);
                }
                catch
                {
                    threadMessage.Abort();
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e) //проверка данных
        {
            if ((cbAddressServer.SelectedIndex == -1) || (cbNameServer.SelectedIndex == -1) || (tbUserServer.Text == String.Empty) || (tbPasswordServer.Text == String.Empty))
                MessageBox.Show(MessageUser.AllMargin, MessageUser.TitleLibrary, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dbConnection.ConnectionDS = cbAddressServer.Text + @"\" + cbNameServer.Text;
                dbConnection.ConnectionUID = tbUserServer.Text;
                dbConnection.ConnectionPassword = tbPasswordServer.Text;
                status = 2;
                lbsstStatus.Text = MessageUser.DatabaseSearch;
                lbsstStatus.Visible = true;
                dbConnection.DataTableDatabases += ListDataBases;
                Thread threadMessageCheck = new Thread(StatusStripMessage);
                Thread threadGetDataBases = new Thread(dbConnection.GetDataBases);
                threadMessageCheck.Priority = ThreadPriority.Lowest;
                threadMessageCheck.IsBackground = true;
                threadMessageCheck.Start();
                threadGetDataBases.Start();
            }
        }

        private void ListDataBases(DataTable table) //получение списка баз данных
        {
            Action action = () =>
            {
                cbListDataBase.Items.Clear();
                foreach (DataRow r in table.Rows)
                {
                    cbListDataBase.Items.Add(r[0]);
                }
                status = 0;
                cbListDataBase.Enabled = true;
                btnConnect.Enabled = true;
            };
            Invoke(action);
        }

        private void btnConnect_Click(object sender, EventArgs e)   //подключение к базе данных
        {
            if ((cbAddressServer.SelectedIndex == -1) || (cbNameServer.SelectedIndex == -1) || (tbUserServer.Text == String.Empty) || (tbPasswordServer.Text == String.Empty) || (cbListDataBase.SelectedIndex == -1))
                MessageBox.Show(MessageUser.AllMargin, MessageUser.TitleLibrary, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RegistryData registryData = new RegistryData();
                registryData.SetRegistry(cbAddressServer.Text, cbNameServer.Text, cbListDataBase.Text, tbUserServer.Text, tbPasswordServer.Text);
                ((MainMenuForm)Owner).MainMenu_Load(sender, e);
                DBConnection.LogConnection = true;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)    //кнопка отмены
        {
            Close();                    
        }

        private void ConnectionForm_FormClosing(object sender, FormClosingEventArgs e)  //закрытие формы
        {
            switch (DBConnection.LogConnection)
            {
                case (true):
                    e.Cancel = false;
                    break;
                case (false):
                    break;
            }
        }
    }
}
