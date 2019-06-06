using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ReturnBookForm : Form
    {
        DBStoredProcedure storedProcedure = new DBStoredProcedure();
        private int countReader = 0;
        private int idReader = 0;
        private int idFormular = 0;

        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            SqlCommand commandReader = new SqlCommand("", RegistryData.DBConnectionString);
            commandReader.CommandText = "select count(*) from [dbo].[Registration_Card_Reader_View] where [Surname_Reader] = '" + tbSurname.Text + "' and [Name_Reader] = '" + tbName.Text + "' and [Patronymic_Reader] = '" + tbPatronymic.Text + "' and [Passport_Series_Reader] = '" + tbPassportSeries.Text + "' and [Passport_Number_Reader] = '" + tbPassportNumber.Text + "'";

            try
            {
                RegistryData.DBConnectionString.Open();
                DBTables dbTables = new DBTables();
                dbTables.CommandOpenKey.ExecuteNonQuery();
                countReader = Convert.ToInt32(commandReader.ExecuteScalar().ToString());
                dbTables.CommandCloseKey.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                RegistryData.ErrorMessage += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
                MessageBox.Show("Читатель с данными параметрами не зарегистрирован в библиотеке.", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                RegistryData.DBConnectionString.Close();
            }

            if (countReader == 0)
            {
                MessageBox.Show("Читатель с данными параметрами не зарегистрирован в библиотеке.", "Библиотека", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSurname.Clear();
                tbName.Clear();
                tbPatronymic.Clear();
                tbPassportSeries.Clear();
                tbPassportNumber.Clear();
            }
            else
            {
                SqlCommand commandIDReader = new SqlCommand("", RegistryData.DBConnectionString);
                commandIDReader.CommandText = "select [ID_Registration_Card_Reader] from [dbo].[Registration_Card_Reader_View] where [Surname_Reader] = '" + tbSurname.Text + "' and [Name_Reader] = '" + tbName.Text + "' and [Patronymic_Reader] = '" + tbPatronymic.Text + "' and [Passport_Series_Reader] = '" + tbPassportSeries.Text + "' and [Passport_Number_Reader] = '" + tbPassportNumber.Text + "'";
                RegistryData.DBConnectionString.Open();
                DBTables dbTables = new DBTables();
                dbTables.CommandOpenKey.ExecuteNonQuery();
                idReader = Convert.ToInt32(commandIDReader.ExecuteScalar().ToString());
                dbTables.CommandCloseKey.ExecuteNonQuery();

                SqlCommand commandIDFormular = new SqlCommand("", RegistryData.DBConnectionString);
                commandIDFormular.CommandText = "select [ID_Formular_Reader] from [dbo].[Formular_Reader] where [Book_Returned] = 0 and [Registration_Card_Reader_ID] = " + idReader.ToString();
                idFormular = Convert.ToInt32(commandIDFormular.ExecuteScalar().ToString());
                RegistryData.DBConnectionString.Close();

                storedProcedure.SPFormularReturnBookUpdate(idFormular);                
            }
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RegistryData.ErrorMessage, "Ошибки в результате работы информационной системы");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
