using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Gasstation
{
    public partial class Registration : Form
    {
        // Создание экземпляра класса SqlFunction
        SqlFunction sf = new SqlFunction();
       
        public Registration()
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
            if (textBoxNameReg.Text == "" || textBoxPasswordReg.Text == "" || textBoxEmailReg.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (sf.RegUsers(textBoxNameReg.Text, textBoxPasswordReg.Text, textBoxEmailReg.Text, textBoxTelReg.Text))
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
            textBoxNameReg.Clear();
            textBoxPasswordReg.Clear();
            textBoxEmailReg.Clear();
        }
    }
}
