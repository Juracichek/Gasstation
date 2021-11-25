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
    public partial class Form1 : Form
    {
        SqlFunction sf = new SqlFunction();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void butReg_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(sf.RegUsers(textBox1.Text, textBox2.Text, textBox3.Text))
                {
                    MessageBox.Show("Вы зарегистрировались!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
