using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Library.Program;

namespace Library
{
    public partial class AuthorizationForm : Form
    {
        DBTables dbTables = new DBTables();        
        private int checkUser = 0;
        public static int userRole = 0;
        public static string FIODirecor = "";

        public AuthorizationForm()
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            //System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            InitializeComponent();
        }

        private void btnAuthorization_Click(object sender, EventArgs e) //клик по кнопке авторизация
        {
            if (tbLogin.TextLength == 0 || tbPassword.TextLength == 0)  //проверка заполненности полей
                MessageBox.Show(MessageUser.AllMargin, MessageUser.TitleLibrary, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlCommand commandSearchUser = new SqlCommand("", RegistryData.DBConnectionString);
                SqlCommand commandRoleUser = new SqlCommand("", RegistryData.DBConnectionString);
                SqlCommand commandFIODirector = new SqlCommand("", RegistryData.DBConnectionString);
                commandSearchUser.CommandText = "select count(*) from[dbo].[User] where CONVERT([nvarchar] (16), DECRYPTBYKEY([Login_User])) = '" + tbLogin.Text + "' and CONVERT([nvarchar] (16), DECRYPTBYKEY([Password_User])) = '" + tbPassword.Text + "'";
                commandRoleUser.CommandText = "select [Role_User_ID] from [dbo].[User] where CONVERT([nvarchar] (16), DECRYPTBYKEY([Login_User])) = '" + tbLogin.Text + "' and CONVERT([nvarchar] (16), DECRYPTBYKEY([Password_User])) = '" + tbPassword.Text + "'";
                commandFIODirector.CommandText = "select [Surname_User] + ' ' + [Name_User] + ' ' + [Patronymic_User] from [dbo].[User] where [Role_User_ID] = 3 and [User_Logical_Delete] = 0;";

                try     //нахождение пользователя таким логином и паролем
                {
                    RegistryData.DBConnectionString.Open();
                    dbTables.CommandOpenKey.ExecuteNonQuery();
                    checkUser = Convert.ToInt32(commandSearchUser.ExecuteScalar().ToString());
                    dbTables.CommandCloseKey.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show(MessageUser.ErrorLoginAndPassord, MessageUser.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    RegistryData.DBConnectionString.Close();
                }

                if (checkUser == 0)
                    MessageBox.Show(MessageUser.NoUserLoginPassword, MessageUser.TitleLibrary, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else     //установление роли данного пользователя
                {

                    RegistryData.DBConnectionString.Open();
                    dbTables.CommandOpenKey.ExecuteNonQuery();
                    userRole = Convert.ToInt32(commandRoleUser.ExecuteScalar().ToString());
                    dbTables.CommandCloseKey.ExecuteNonQuery();                   
                    RegistryData.DBConnectionString.Close();

                    if (userRole == 3)
                    {
                        RegistryData.DBConnectionString.Open();
                        FIODirecor = commandFIODirector.ExecuteScalar().ToString();
                        RegistryData.DBConnectionString.Close();
                    }

                    MessageBox.Show(MessageUser.SuccessfullyAuthoriz, MessageUser.TitleLibrary, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EnableComponent.EventHandler(userRole);                    
                    this.Hide();                       
                }
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)  //клик по кнопке регистрация
        {
            RegistrationForm registrationForm = new RegistrationForm();
            this.Hide();
            registrationForm.Show();
        }
    }
}
