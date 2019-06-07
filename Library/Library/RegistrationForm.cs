using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class RegistrationForm : Form
    {
        UsersForm usersForm = new UsersForm();
        DBTables dbTables = new DBTables();
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private int uniqueLogin = 1;
        private int uniquePassword = 1;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnAuthorization_Click(object sender, EventArgs e) //кнопка аторизация
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            this.Hide();
            authorizationForm.Show();
        }

        private bool CheckOccupancyTextBox()    //функция проверки количества симвоолов в полях для ввода
        {
            if (tbSurname.TextLength == 0 || tbName.TextLength == 0 || tbPatronymic.TextLength == 0 || tbPassword.TextLength == 0 || tbRepeatPassword.TextLength == 0)
                MessageBox.Show("Должны быть заполнены все поля!", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                return true;

            return false;
        }

        private bool CheckCoincidencePasswords()    //функция проверки одинаковости полей пароль и поторить пароль
        {
            if (tbPassword.Text != tbRepeatPassword.Text)
                MessageBox.Show("Поля Пароль и Повторите пароль должны совпадать!", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                return true;

            return false;
        }

        private bool CheckLenghtLoginPassword() //функция проверки длины логина и пароля
        {
            if ((tbLogin.TextLength < 8) || (tbPassword.TextLength < 8))
                MessageBox.Show("Логин и пароль должны иметь минимальную длину 8 символов!", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                return true;

            return false;
        }

        private bool CheckTextLoginPassword()   //функция проверки
        {
            if (usersForm.CheckPasswordUpperLatin() == true || usersForm.CheckPasswordLowerLatin() == true || usersForm.CheckPasswordUpperCyrill() == true || usersForm.CheckPasswordLowerCyrill() == true || usersForm.CheckPasswordNumber() == true || usersForm.CheckPassworSymbol() == true || usersForm.CheckLoginCyrill() == false)
                MessageBox.Show("Логин не должен иметь русских букв! Пароль должен иметь хотя бы одну заглавную английскую и русскую буквы, одну прописную английскую и русскую буквы, цифру, спецсимвол!", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                return true;

            return false;
        }

        private bool CheckUniqueLogin() //функция проверки уникальности логина
        {
            SqlCommand commandSearchLogin = new SqlCommand("", RegistryData.DBConnectionString);
            commandSearchLogin.CommandText = "select count(*) from [dbo].[User] where CONVERT([nvarchar] (16), DECRYPTBYKEY([Login_User])) = '" + tbLogin.Text + "'";

            RegistryData.DBConnectionString.Open();
            dbTables.CommandOpenKey.ExecuteNonQuery();
            uniqueLogin = Convert.ToInt32(commandSearchLogin.ExecuteScalar().ToString());
            dbTables.CommandCloseKey.ExecuteNonQuery();
            RegistryData.DBConnectionString.Close();

            if (uniqueLogin != 0)
                MessageBox.Show("Пользователь с таким логином уже числится в информационной системе!", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                return true;

            return false;
        }

        private bool CheckUniquePassword()  //функция проверки уникальности пароля
        {
            SqlCommand commandSearchPassword = new SqlCommand("", RegistryData.DBConnectionString);
            commandSearchPassword.CommandText = "select count(*) from [dbo].[User] where CONVERT([nvarchar] (16), DECRYPTBYKEY([Password_User])) = '" + tbPassword.Text + "'";

            RegistryData.DBConnectionString.Open();
            dbTables.CommandOpenKey.ExecuteNonQuery();
            uniquePassword = Convert.ToInt32(commandSearchPassword.ExecuteScalar().ToString());
            dbTables.CommandCloseKey.ExecuteNonQuery();
            RegistryData.DBConnectionString.Close();

            if (uniquePassword != 0)
                MessageBox.Show("Пользователь с таким паролем уже числится в информационной системе!", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                return true;

            return false;
        }

        private void btnRegistration_Click(object sender, EventArgs e)  //кнопка регистрации
        {
            if (CheckOccupancyTextBox() == true && CheckCoincidencePasswords() == true && CheckLenghtLoginPassword() == true && CheckTextLoginPassword() == true && CheckUniqueLogin() == true && CheckUniquePassword() == true)
            {
                storedProcedure.SPUserInsert(tbSurname.Text, tbName.Text, tbPatronymic.Text, tbLogin.Text, tbPassword.Text, 2);
                MessageBox.Show("Вы успешно зарегистрировались в информационной системе! В данный момент у Вас права Гостя. " +
                    "Обратитесь к системному администратору, чтобы он изменил ваши права. Теперь пройдите авторизацию для " +
                    "работы с информационной системой.", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAuthorization_Click(sender, e);
            }
        }        
    }
}
