using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Library
{
    public partial class UsersForm : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private SqlCommand commandSearchUser = new SqlCommand("", RegistryData.DBConnectionString);
        private string filterUser = "";
        private string constraintUpperLatin = @"[A-Z]";
        private string constraintLowerLatin = @"[a-z]";
        private string constraintUpperCyrill = @"[А-Я]";
        private string constraintLowerCyrill = @"[а-я]";
        private string constraintNumber = @"[0-9]";
        private string constraintSymbol = @"[%!@#$%^&*()?№]";
        private string constraintLoginCyrill = @"[аА-яЯ]";
        private bool checkUpperLatin = false;
        private bool checkLowerLatin = false;
        private bool checkUpperCyrill = false;
        private bool checkLowerCyrill = false;
        private bool checkNumber = false;
        private bool checkSymbol = false;
        private bool checkLoginCyrill = false;
        private bool uniquePassword = false;
        private bool uniqueLogin = false;

        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e) //загрузка формы
        {
            Thread threadUser = new Thread(UserFill);
            Thread threadRoleUser = new Thread(RoleUserFill);
            threadUser.Start();
            threadRoleUser.Start();
        }

        private void UserFill() //заполнение data grid view данными из базы данных
        {
            DBTables dbTables = new DBTables();

            Action action = () =>
            {
                dbTables.DTUsers.Clear();
                dbTables.DTUsersFill();
                filterUser = dbTables.QRUsers;
                dbTables.dependency.OnChange += ChangeDataUsers;

                dgvUsers.DataSource = dbTables.DTUsers;
                dgvUsers.Columns[0].Visible = false;
                dgvUsers.Columns[1].HeaderText = "Фамилия";
                dgvUsers.Columns[2].HeaderText = "Имя";
                dgvUsers.Columns[3].HeaderText = "Отчество";
                dgvUsers.Columns[4].HeaderText = "Логин";
                dgvUsers.Columns[5].HeaderText = "Пароль";
                dgvUsers.Columns[6].Visible = false;
                dgvUsers.Columns[7].HeaderText = "Роль";
                dgvUsers.ClearSelection();
            };
            Invoke(action);
        }

        private void RoleUserFill() //заполнение combo box данными из базы данных
        {
            DBTables dbTables = new DBTables();

            Action action = () =>
            {
                dbTables.DTRoleUser.Clear();
                dbTables.DTRoleUserForComboBox();
                dbTables.dependency.OnChange += ChangeDataRoleUsers;

                cbRole.DataSource = dbTables.DTRoleUser;
                cbRole.ValueMember = "ID_Role_User";
                cbRole.DisplayMember = "Role_Name";
            };
            Invoke(action);
        }

        private void ChangeDataUsers(object sender, SqlNotificationEventArgs e) //отслеживание изменения в базе данных
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                UserFill();
            }
        }

        private void ChangeDataRoleUsers(object sender, SqlNotificationEventArgs e) //отслеживание изменения в базе данных
        {
            if (e.Info != SqlNotificationInfo.Invalid)
            {
                RoleUserFill();
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)  //клик по полю data grid view
        {
            tbSurname.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            tbName.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            tbPatronymic.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
            tbLogin.Text = dgvUsers.CurrentRow.Cells[4].Value.ToString();
            tbPassword.Text = dgvUsers.CurrentRow.Cells[5].Value.ToString();
            cbRole.SelectedValue = dgvUsers.CurrentRow.Cells[6].Value.ToString();
        }

        private bool CheckPasswordUpperLatin()  //проверка наличия заглавных английских букв
        {
            checkUpperLatin = Regex.IsMatch(tbPassword.Text, constraintUpperLatin, RegexOptions.None) ? true : false;

            return checkUpperLatin;
        }

        private bool CheckPasswordLowerLatin()  //проверка наличия прописных английских букв
        {
            checkLowerLatin = Regex.IsMatch(tbPassword.Text, constraintLowerLatin, RegexOptions.None) ? true : false;

            return checkLowerLatin;
        }

        private bool CheckPasswordUpperCyrill() //проверка наличия заглавных русских букв
        {
            checkUpperCyrill = Regex.IsMatch(tbPassword.Text, constraintUpperCyrill, RegexOptions.None) ? true : false;

            return checkUpperCyrill;
        }

        private bool CheckPasswordLowerCyrill() //проверка наличия прописных русских букв
        {
            checkLowerCyrill = Regex.IsMatch(tbPassword.Text, constraintLowerCyrill, RegexOptions.None) ? true : false;

            return checkLowerCyrill;
        }

        private bool CheckPasswordNumber()  //проверка наличия цифр
        {
            checkNumber = Regex.IsMatch(tbPassword.Text, constraintNumber, RegexOptions.None) ? true : false;

            return checkUpperLatin;
        }

        private bool CheckPassworSymbol()   //проверка наличия символов
        {
            checkSymbol = Regex.IsMatch(tbPassword.Text, constraintSymbol, RegexOptions.None) ? true : false;

            return checkSymbol;
        }

        private bool CheckLoginCyrill() //проверка наличия русских букв
        {
            checkLoginCyrill = Regex.IsMatch(tbPassword.Text, constraintLoginCyrill, RegexOptions.None) ? false : true;

            return checkLoginCyrill;
        }

        private bool CheckUniqueLogin(Button button)    //проверка уникальности логина
        {
            int currentRow = 0;

            if (button.Name == "btnUpdate")
                currentRow = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString());
            else
                currentRow = -1;

            for (int i = 0; i < dgvUsers.RowCount; i++)
            {
                if (i + 1 == currentRow)
                    continue;
                else
                    if ((tbLogin.Text) == (dgvUsers.Rows[i].Cells[4].Value.ToString()))
                {
                    uniqueLogin = false;
                    return uniqueLogin;
                }
                else
                    uniqueLogin = true;
            }

            return uniqueLogin;
        }

        private bool CheckUniquePassword(Button button) //проверка уникальности пароля
        {
            int currentRow = 0;

            if (button.Name == "btnUpdate")
                currentRow = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString());
            else
                currentRow = -1;

            for (int i = 0; i < dgvUsers.RowCount; i++)
            {
                if (i + 1 == currentRow)
                    continue;
                else
                    if ((tbPassword.Text) == (dgvUsers.Rows[i].Cells[5].Value.ToString()))
                {
                    uniquePassword = false;
                    return uniquePassword;
                }
                else
                    uniquePassword = true;
            }

            return uniquePassword;
        }

        private void btnInsert_Click(object sender, EventArgs e)    //кнопка добавления записии
        {
            var nameButton = sender as Button;

            if ((tbLogin.TextLength >= 8) && (tbPassword.TextLength >= 8) && CheckUniqueLogin(nameButton) == true && CheckUniquePassword(nameButton) == true && (tbPassword.Text == tbRepeatPassword.Text) && CheckPasswordUpperLatin() == true && CheckPasswordLowerLatin() == true && CheckPasswordUpperCyrill() == true && CheckPasswordLowerCyrill() == true && CheckPasswordNumber() == true && CheckPassworSymbol() == true && CheckLoginCyrill() == false)
                storedProcedure.SPUserInsert(tbSurname.Text, tbName.Text, tbPatronymic.Text, tbLogin.Text, tbPassword.Text, Convert.ToInt32(cbRole.SelectedValue.ToString()));
            else
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + "проверьте правильность ввода данных! Поля Логин и Пароль " +
                    "должны быть длиною от 8 до 16 символов. Поле Логин н должно содержать русских букв. Поле Пароль должно обязательно содержать " +
                    "хотя бы: одну заглавную английскую букву, одну прописную английскую букву, одну заглавную русскую букву, одну прописную " +
                    "русскую букву, одну цифру, один спецсимвол. Поля Пароль и Повторите пароль должны совпадать.";

            UserFill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)    //кнопка изменения записи
        {
            var nameButton = sender as Button;

            if ((tbLogin.TextLength >= 8) && (tbPassword.TextLength >= 8) && CheckUniqueLogin(nameButton) == true && CheckUniquePassword(nameButton) == true && (tbPassword.Text == tbRepeatPassword.Text) && CheckPasswordUpperLatin() == true && CheckPasswordLowerLatin() == true && CheckPasswordUpperCyrill() == true && CheckPasswordLowerCyrill() == true && CheckPasswordNumber() == true && CheckPassworSymbol() == true && CheckLoginCyrill() == false)
                storedProcedure.SPUserUpdate(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString()), tbSurname.Text, tbName.Text, tbPatronymic.Text, tbLogin.Text, tbPassword.Text, Convert.ToInt32(cbRole.SelectedValue.ToString()));
            else
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + "проверьте правильность ввода данных! Поля Логин и Пароль " +
                    "должны быть длиною от 8 до 16 символов. Поле Логин н должно содержать русских букв. Поле Пароль должно обязательно содержать " +
                    "хотя бы: одну заглавную английскую букву, одну прописную английскую букву, одну заглавную русскую букву, одну прописную " +
                    "русскую букву, одну цифру, один спецсимвол. Поля Пароль и Повторите пароль должны совпадать.";

            UserFill();
        }

        private void btnDelete_Click(object sender, EventArgs e)    //кнопка удаления записи
        {
            switch (MessageBox.Show("Удалить пользователя " + tbSurname.Text + " " + tbName.Text + " " + tbPatronymic.Text + "?", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    storedProcedure.SPUserDelete(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString()));
                    dgvUsers.ClearSelection();
                    tbSurname.Clear();
                    tbName.Clear();
                    tbPatronymic.Clear();
                    tbPassword.Clear();
                    tbLogin.Clear();
                    tbRepeatPassword.Clear();
                    cbRole.SelectedValue = -1;
                    UserFill();
                    break;
            }
        }

        private void btnUpdatePost_Click(object sender, EventArgs e) //открытие справочника должности
        {
            PostForm postForm = new PostForm();
            postForm.Show(this);
        }

        private void tbSearch_Click(object sender, EventArgs e) //клик по полю поиска
        {
            tbSearch.Clear();
        }

        private void tbSearch_Leave(object sender, EventArgs e) //поле поиска больше не в фокусе
        {
            if (tbSearch.Text == "")
                tbSearch.Text = "Введите данные пользователя...";
        }

        private void tbSearch_Enter(object sender, EventArgs e) //клик по полю поиска
        {
            if (tbSearch.Text == "Введите данные пользователя...")
                tbSearch.Clear();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)   //введение текста в поле поиска
        {
            chbFiltration_CheckedChanged(sender, e);
        }

        private void chbFiltration_CheckedChanged(object sender, EventArgs e)   //изменение check box
        {
            switch (chbFiltration.CheckState)
            {
                case (CheckState.Checked):  //фильтрация
                    DataTable data = new DataTable("User");
                    commandSearchUser.CommandText = filterUser + " and [Surname_User] like '%" + tbSearch.Text + "%' or [Name_User] like '%" + 
                        tbSearch.Text + "%' or [Patronymic_User] like '%" + tbSearch.Text + "%' or [Login_User] like '%" + tbSearch.Text + 
                        "%' or [Password_User] like '%" + tbSearch.Text + "%' or [Role_Name] like '%" + tbSearch.Text + "%'";
                    RegistryData.DBConnectionString.Open();
                    DBTables dbTables = new DBTables();
                    dbTables.CommandOpenKey.ExecuteNonQuery();
                    data.Load(commandSearchUser.ExecuteReader());
                    dbTables.CommandCloseKey.ExecuteNonQuery();
                    RegistryData.DBConnectionString.Close();

                    dgvUsers.DataSource = data;
                    dgvUsers.Columns[0].Visible = false;
                    dgvUsers.Columns[1].HeaderText = "Фамилия";
                    dgvUsers.Columns[2].HeaderText = "Имя";
                    dgvUsers.Columns[3].HeaderText = "Отчество";
                    dgvUsers.Columns[4].HeaderText = "Логин";
                    dgvUsers.Columns[5].HeaderText = "Пароль";
                    dgvUsers.Columns[6].Visible = false;
                    dgvUsers.Columns[7].HeaderText = "Роль";
                    dgvUsers.ClearSelection();
                    break;

                case (CheckState.Unchecked):    //поиск
                    UserFill();

                    for (int i = 0; i < dgvUsers.RowCount; i++)
                    {
                        for (int j = 0; j < dgvUsers.ColumnCount; j++)
                        {
                            if (dgvUsers.Rows[i].Cells[j].Value != null)
                                if (dgvUsers.Rows[i].Cells[j].Value.ToString().Contains(tbSearch.Text))
                                {
                                    dgvUsers.Rows[i].Selected = true;
                                    break;
                                }
                        }
                    }
                    break;
            }
        }

        private void btnError_Click(object sender, EventArgs e) //кнопка ошибк
        {
            MessageBox.Show(RegistryData.ErrorMessage, "Ошибки в результате работы информационной системы");
        }

        private void btnExit_Click(object sender, EventArgs e)  //кнопка закрыть
        {
            Close();
        }
    }
}
