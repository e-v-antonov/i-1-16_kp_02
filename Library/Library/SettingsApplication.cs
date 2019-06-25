using System;
using System.IO;
using System.Windows.Forms;

namespace Library
{
    public partial class SettingsApplication : Form
    {
        RegistryData registryData = new RegistryData();

        public SettingsApplication()
        {
            InitializeComponent();
        }

        private void SettingsApplication_Load(object sender, EventArgs e)   //открытие окна настроек
        {
            registryData.ConfigurationGet();
            if (RegistryData.DirPath == "")
            {
                tbPath.Text= "C:\\Users\\" + SystemInformation.UserName + "\\Documents\\Отчёты";
                if (!Directory.Exists(tbPath.Text))
                    Directory.CreateDirectory(tbPath.Text);
            }
            else
                tbPath.Text = RegistryData.DirPath;

            cbLanguage.DataSource = new System.Globalization.CultureInfo[]{
                System.Globalization.CultureInfo.GetCultureInfo("ru-RU"),
                System.Globalization.CultureInfo.GetCultureInfo("en-US")
            };

            cbLanguage.DisplayMember = "NativeName";
            cbLanguage.ValueMember = "Name"; 

            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                cbLanguage.SelectedValue = Properties.Settings.Default.Language;
            }
        }

        private void ChangeLanguage_Click(object sender, EventArgs e)   //изменение языка
        {
            switch (MessageBox.Show(MessageUser.QuestionChangeLanguage, MessageUser.TitleLibrary, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Properties.Settings.Default.Language = cbLanguage.SelectedValue.ToString();
                    Properties.Settings.Default.Save();
                    Application.Restart();
                    break;
            }           
        }

        private void btnPath_Click(object sender, EventArgs e)  //изменение пути сохранения
        {
            fbdPath.ShowDialog();
            tbPath.Text = fbdPath.SelectedPath;

            string document_default_path = "";
            switch (tbPath.Text == "")
            {
                case (true):
                    document_default_path = "C:\\Users\\" + SystemInformation.UserName + "\\Documents\\Отчёты";
                    if (!Directory.Exists(document_default_path))
                        Directory.CreateDirectory(document_default_path);
                    break;

                case (false):
                    document_default_path = tbPath.Text;
                    if (!Directory.Exists(document_default_path))
                        Directory.CreateDirectory(document_default_path);
                    break;
            }
            registryData.ConfigurationSet(tbPath.Text);
        }
    }
}
