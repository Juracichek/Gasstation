using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Gasstation
{
    public partial class Reg : Form
    {
        // Создание экземпляра класса SqlFunction
        SqlFunction sf = new SqlFunction();

        public Reg()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Кнопка "Вход" - переход на форму Авторизации
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization a = new Authorization();
            a.Show();
        }

        // Кнопка "Регистрация" - чтобы зарегать пользователя
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (textBoxLoginReg.Text == "" || textBoxPasswordReg.Text == "" || textBoxEmailReg.Text == "" || textBoxTelReg.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(textBoxEmailReg.Text, pattern, RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("Email подтверждён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Некорректный email");
                    return;
                }

                string pattern2 = "[0-9]{3}-[0-9]{2}-[0-9]{2}";
                if (Regex.IsMatch(textBoxTelReg.Text, pattern2, RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("Телефон введён верно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Неверно введён телефон");
                    return;
                }
                if (sf.RegUsers(textBoxLoginReg.Text, textBoxPasswordReg.Text, textBoxEmailReg.Text, textBoxTelReg.Text))
                {
                    MessageBox.Show("Регистрация прошла успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Authorization at = new Authorization();
                    at.Show();
                }
                else
                {
                    MessageBox.Show("Проверьте правильность написания Вашего имени или Пароля или зарегистрируйтесь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Кнопка для очистки полей
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLoginReg.Clear();
            textBoxPasswordReg.Clear();
            textBoxEmailReg.Clear();
            textBoxTelReg.Clear();
        }

        private void buttonClear_MouseEnter(object sender, EventArgs e)
        {
            buttonClear.BackColor = Color.FromArgb(251, 206, 177);
        }

        private void buttonRegistration_MouseEnter(object sender, EventArgs e)
        {
            buttonRegistration.BackColor = Color.FromArgb(251, 206, 177);
        }

        private void buttonSignIn_MouseEnter(object sender, EventArgs e)
        {
            buttonSignIn.BackColor = Color.FromArgb(251, 206, 177);
        }

        private void buttonClear_MouseLeave(object sender, EventArgs e)
        {
            buttonClear.BackColor = Color.White;
        }

        private void buttonRegistration_MouseLeave(object sender, EventArgs e)
        {
            buttonRegistration.BackColor = Color.White;
        }

        private void buttonSignIn_MouseLeave(object sender, EventArgs e)
        {
            buttonSignIn.BackColor = Color.White;
        }
    }
}
