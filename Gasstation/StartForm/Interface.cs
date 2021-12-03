using Gasstation.Resources.Scripts;
using Gasstation.StartForm.Interface;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gasstation
{
    public partial class Interface : Form
    {
        SqlFunction sf = new SqlFunction();
        Account ac = new Account();

        private Form activeForm;

        public Interface()
        {
            InitializeComponent();
        }

        public Interface(string login)
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = sf.GetClient(login);
            ac.Id = dt.Rows[0][0].ToString();
            ac.Login = dt.Rows[0][1].ToString();
            ac.Email = dt.Rows[0][3].ToString();
            ac.Phone = dt.Rows[0][4].ToString();
            ac.Get();
        }

        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            buttonProfile.BackColor = Color.Firebrick;
            OpenChildForm(new FormProfile(ac));
        }

        private void buttonTuck_Click(object sender, EventArgs e)
        {
            buttonTuck.BackColor = Color.Firebrick;
            OpenChildForm(new FormTuck(ac));
        }

        private void buttonProfile_Leave(object sender, EventArgs e)
        {
            buttonProfile.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void buttonTuck_Leave(object sender, EventArgs e)
        {
            buttonTuck.BackColor = Color.FromArgb(51, 51, 76);
        }


        private void buttonCard_Click(object sender, EventArgs e)
        {
            buttonCard.BackColor = Color.Firebrick;
            OpenChildForm(new FormCard(ac));
        }

        private void buttonCard_Leave(object sender, EventArgs e)
        {
            buttonCard.BackColor = Color.FromArgb(51, 51, 76); ;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            buttonHistory.BackColor = Color.Firebrick;
            OpenChildForm(new FormHistory(ac));
        }

        private void buttonHistory_Leave(object sender, EventArgs e)
        {
            buttonHistory.BackColor = Color.FromArgb(51, 51, 76);
        }
    }
}
