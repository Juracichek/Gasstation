using Gasstation.StartForm;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gasstation
{
    public partial class Authorization : Form
    {
       SqlFunction sf = new SqlFunction();

        public Authorization()
        {
            InitializeComponent();
        }

        // Кнопка "Вход" - войти в систему
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (sf.LogUsers(textBoxLogin.Text, textBoxPassword.Text))
                {
                    MessageBox.Show("Авторизация прошла успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Interface i = new Interface(textBoxLogin.Text);
                    i.Show();
                }
                else
                {
                    if (textBoxLogin.Text == "admin" && textBoxPassword.Text == "admin")
                    {
                        this.Hide();
                        AdminForm af = new AdminForm();
                        af.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка входа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        // Кнопка "Регистрация" - перейти на форму Регистрации (Form1)        
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reg reg = new Reg();
            reg.Show();
        }

        // Кнопка дял очистки полей
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }

        private void buttonClear_MouseEnter(object sender, EventArgs e)
        {
            buttonClear.BackColor = Color.FromArgb(251, 206, 177);
        }

        private void buttonSignIn_MouseEnter(object sender, EventArgs e)
        {
            buttonSignIn.BackColor = Color.FromArgb(251, 206, 177);
        }

        private void buttonRegistration_MouseEnter(object sender, EventArgs e)
        {
            buttonRegistration.BackColor = Color.FromArgb(251, 206, 177);
        }

        private void buttonClear_MouseLeave(object sender, EventArgs e)
        {
            buttonClear.BackColor = Color.White;
        }

        private void buttonSignIn_MouseLeave(object sender, EventArgs e)
        {
            buttonSignIn.BackColor = Color.White;
        }

        private void buttonRegistration_MouseLeave(object sender, EventArgs e)
        {
            buttonRegistration.BackColor = Color.White;
        }
    }
}
