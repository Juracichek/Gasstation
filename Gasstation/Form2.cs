﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (textBoxName.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (sf.LogUsers(textBoxName.Text, textBoxPassword.Text))
                {
                    MessageBox.Show("Авторизация прошла успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Show();
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
            Registration reg = new Registration();
            reg.Show();
        }
    }
}
