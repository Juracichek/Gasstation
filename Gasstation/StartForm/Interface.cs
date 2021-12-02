using Gasstation.StartForm.Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gasstation
{
    public partial class Interface : Form
    {
        private Form activeForm;

        public Interface()
        {
            InitializeComponent();
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
            OpenChildForm(new FormProfile());
        }

        private void buttonTuck_Click(object sender, EventArgs e)
        {
            buttonTuck.BackColor = Color.Firebrick;
            OpenChildForm(new FormTuck());
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
            OpenChildForm(new FormCard());
        }

        private void buttonCard_Leave(object sender, EventArgs e)
        {
            buttonCard.BackColor = Color.Firebrick;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            buttonHistory.BackColor = Color.Firebrick;
            OpenChildForm(new FormHistory());
        }

        private void buttonHistory_Leave_1(object sender, EventArgs e)
        {
            buttonHistory.BackColor = Color.FromArgb(51, 51, 76);
        }
    }
}
