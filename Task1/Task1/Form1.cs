using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            txtSurname.ForeColor = Color.Gray;
            txtName.ForeColor = Color.Gray;
            txtLogin.ForeColor = Color.Gray;
        }
        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {
            txtSurname.ForeColor = Color.Black;
            foreach (char c in txtSurname.Text)
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    lDiagnost.Text = "* У прізвищі мають бути лише літери";
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            txtName.ForeColor = Color.Black;
            foreach (char c in txtName.Text)
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    lDiagnost.Text = "* В імені мають бути лише літери";
        }

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {
            txtLogin.ForeColor = Color.Black;
        }

        private bool CheckEmptyTextBox()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSurname.Text) || txtSurname.Text == "Прізвище" ||
                    string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text == "Ім'я" ||
                    string.IsNullOrWhiteSpace(txtLogin.Text))
                    throw new Exception("Усі текстові поля обов'язкові.");

                if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPassword1.Text))
                    throw new Exception("Введіть пароль.");

                return true;
            }
            catch (Exception ex)
            {
                lDiagnost.Text = "* " + ex.Message;
                return false;
            }
        }

        private bool CheckPassword()
        {
            try
            {
                if (txtPassword.Text != txtPassword1.Text)
                    throw new Exception("Паролі не співпадають.");
                if (txtPassword.Text.Length < 6)
                    throw new Exception("Пароль має бути не менше 6 символів.");
                return true;
            }
            catch (Exception ex)
            {
                lDiagnost.Text = "* " + ex.Message;
                return false;
            }
        }

        private bool CheckLogin()
        {
            Regex myReg1 = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            if (!myReg1.IsMatch(txtLogin.Text))
            {
                lDiagnost.Text = "* Невірний формат логіну (Email).";
                return false;
            }
            return true;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            lDiagnost.Text = "";

            if (CheckEmptyTextBox() && CheckPassword() && CheckLogin())
            {
                string gender = rbMale.Checked ? "Чоловіча" : "Жіноча";
                string birthDate = $"{numDay.Value:00}.{numMonth.Value:00}.{numYear.Value}";

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("--- РЕЄСТРАЦІЙНІ ДАНІ ---");
                sb.AppendLine($"Прізвище: {txtSurname.Text}");
                sb.AppendLine($"Ім'я: {txtName.Text}");
                sb.AppendLine($"Логін: {txtLogin.Text}");
                sb.AppendLine($"Стать: {gender}");
                sb.AppendLine($"Дата народження: {birthDate}");
                sb.AppendLine($"Пароль: {new string('*', txtPassword.Text.Length)}");
                sb.AppendLine("-------------------------");

                txtOutput.Text = sb.ToString();
                lDiagnost.Text = "Дані успішно збережено!";
                lDiagnost.ForeColor = Color.Green;
            }
            else
            {
                lDiagnost.ForeColor = Color.Red;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
