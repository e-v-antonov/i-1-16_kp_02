using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ConnectionForm : Form
    {
        private DBConnection dbConnection = new DBConnection();
        private int status = 1;
        public Thread threadGetServers;
        public Thread threadMessage;
        public Thread threadMessage1;
        public Thread threadGetDataBases;
        

        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
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
                    lbsstStatus.Text = "Поиск серверов";
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

        private void DTServers(DataTable table)
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

        private void StatusStripMessage()
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
                                if (lbsstStatus.Text != "Поиск серверов...")
                                    lbsstStatus.Text += ".";
                                else
                                    lbsstStatus.Text = "Поиск серверов";
                                break;
                            case (2):
                                if (lbsstStatus.Text != "Поиск баз данных...")
                                    lbsstStatus.Text += ".";
                                else
                                    lbsstStatus.Text = "Поиск баз данных";
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if ((cbAddressServer.SelectedIndex == -1) || (cbNameServer.SelectedIndex == -1) || (tbUserServer.Text == String.Empty) || (tbPasswordServer.Text == String.Empty))
                MessageBox.Show("Заполните все поля!", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dbConnection.ConnectionDS = cbAddressServer.Text + @"\" + cbNameServer.Text;
                dbConnection.ConnectionUID = tbUserServer.Text;
                dbConnection.ConnectionPassword = tbPasswordServer.Text;
                status = 2;
                lbsstStatus.Text = "Поиск баз данных";
                lbsstStatus.Visible = true;
                dbConnection.DataTableDatabases += ListDataBases;
                Thread threadMessage1 = new Thread(StatusStripMessage);
                Thread threadGetDataBases = new Thread(dbConnection.GetDataBases);
                threadMessage1.Priority = ThreadPriority.Lowest;
                threadMessage1.IsBackground = true;
                threadMessage1.Start();
                threadGetDataBases.Start();
            }
        }

        private void ListDataBases(DataTable table)
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

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if ((cbAddressServer.SelectedIndex == -1) || (cbNameServer.SelectedIndex == -1) || (tbUserServer.Text == String.Empty) || (tbPasswordServer.Text == String.Empty) || (cbListDataBase.SelectedIndex == -1))
                MessageBox.Show("Заполните все поля!", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RegistryData registryData = new RegistryData();
                registryData.SetRegistry(cbAddressServer.Text, cbNameServer.Text, cbListDataBase.Text, tbUserServer.Text, tbPasswordServer.Text);
                ((MainMenuForm)Owner).MainMenu_Load(sender, e);
                DBConnection.LogConnection = true;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();                    
        }

        private void ConnectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (DBConnection.LogConnection)
            {
                case (true):
                    e.Cancel = false;
                    break;
                case (false):
                    //Application.Exit();
                    break;
            }
        }
    }
}
