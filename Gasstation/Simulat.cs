using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasstation
{
    public partial class Simulation : Form
    {
        SqlFunction sf = new SqlFunction();
        private bool Working;

        public Simulation()
        {
            InitializeComponent();
        }
        
        string[] logins = { "ilya12", "kifdh244", "nrh45" };
        string[] passwords = { "345", "4gh57", "4j582" };
        string[] phons = { "110022", "456789", "109876" };
        string[] emails = { "atr@gmail.com", "pr@yandex.ru", "HJ@gmail.com" };
        Random random = new Random();
        int count = 0; // счётчик для регистрации

        public void Registration()
        {
            while(Working)
            { 
                string login = logins[random.Next(0, logins.Length)] + random.Next(10000, 99999);
                string password = passwords[random.Next(0, passwords.Length)];
                string phone = phons[random.Next(0, phons.Length)];
                string email = emails[random.Next(0, emails.Length)];
                sf.RegUsers(login, password, phone, email);
                count++;
                label1.Invoke(new Action(() => label1.Text = count.ToString()));
                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Working = true;
            Task.Run(() => Registration());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Working = false;
        }
    }
}
