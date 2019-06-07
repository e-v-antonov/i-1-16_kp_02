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

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void btnAuthorization_Click(object sender, EventArgs e) //клик по кнопке авторизация
        {
            if (tbLogin.TextLength == 0 || tbPassword.TextLength == 0)  //проверка заполненности полей
                MessageBox.Show("Все поля должны быть заполнены!", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlCommand commandSearchUser = new SqlCommand("", RegistryData.DBConnectionString);
                SqlCommand commandRoleUser = new SqlCommand("", RegistryData.DBConnectionString);
                commandSearchUser.CommandText = "select count(*) from[dbo].[User] where CONVERT([nvarchar] (16), DECRYPTBYKEY([Login_User])) = '" + tbLogin.Text + "' and CONVERT([nvarchar] (16), DECRYPTBYKEY([Password_User])) = '" + tbPassword.Text + "'";
                commandRoleUser.CommandText = "select [Role_User_ID] from [dbo].[User] where CONVERT([nvarchar] (16), DECRYPTBYKEY([Login_User])) = '" + tbLogin.Text + "' and CONVERT([nvarchar] (16), DECRYPTBYKEY([Password_User])) = '" + tbPassword.Text + "'";

                try     //нахождение пользователя таким логином и паролем
                {
                    RegistryData.DBConnectionString.Open();
                    dbTables.CommandOpenKey.ExecuteNonQuery();
                    checkUser = Convert.ToInt32(commandSearchUser.ExecuteScalar().ToString());
                    dbTables.CommandCloseKey.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка проверки логина и пароля пользователя!", "Ошибки в результате работы информационной системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    RegistryData.DBConnectionString.Close();
                }

                if (checkUser == 0)
                    MessageBox.Show("Пользователя с данным логин и паролем не обнаружено! Проверьте правильность ввода данных или зарегистрируйтесь.", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else     //установление роли данного пользователя
                {

                    RegistryData.DBConnectionString.Open();
                    dbTables.CommandOpenKey.ExecuteNonQuery();
                    userRole = Convert.ToInt32(commandRoleUser.ExecuteScalar().ToString());
                    dbTables.CommandCloseKey.ExecuteNonQuery();                   
                    RegistryData.DBConnectionString.Close();
                    MessageBox.Show("Вы авторизовались в информационной системе.", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EnableComponent.EventHandler(true);
                    this.Hide();                       
                }
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)  //клик по кнопке регистрация
        {
            RegistrationForm registrationForm = new RegistrationForm();
            this.Hide();
            registrationForm.Show(this);
        }
    }
}
