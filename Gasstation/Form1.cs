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

        private SqlConnection conn = null;
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
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

            conn.Open();

            if(conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Подключение установлено");
            }
        }

        private void butReg_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"INSERT INTO [users] (name, password, email) VALUES (@name, @password, @email)", conn);
            cmd.Parameters.AddWithValue("name", textBox1.Text);
            cmd.Parameters.AddWithValue("password", textBox2.Text);
            cmd.Parameters.AddWithValue("email", textBox3.Text);
            //cmd.ExecuteNonQuery();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Вы зарегистрировались!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form2 form = new Form2();
                    form.Show();

                }
            }
        }
    }
}
