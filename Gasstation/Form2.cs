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

namespace Gasstation
{
    public partial class Form2 : Form
    {
       SqlFunction sf = new SqlFunction();

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (sf.LogUsers(textBox1.Text, textBox2.Text))
                {
                    MessageBox.Show("Вы авторизованы", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Show();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
