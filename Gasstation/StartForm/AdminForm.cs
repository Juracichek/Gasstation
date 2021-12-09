using Gasstation.Resources.Scripts;
using Gasstation.StartForm.Interface;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gasstation.StartForm
{
    public partial class AdminForm : Form
    {
        private Form activeF;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminOpenChildForm(Form adminChildForm)
        {
            if (activeF != null)
            {
                activeF.Close();
            }
            activeF = adminChildForm;
            adminChildForm.TopLevel = false;
            adminChildForm.FormBorderStyle = FormBorderStyle.None;
            adminChildForm.Dock = DockStyle.Fill;
            this.panelAdminDesktop.Controls.Add(adminChildForm);
            this.panelAdminDesktop.Tag = adminChildForm;
            adminChildForm.BringToFront();
            adminChildForm.Show();
            labelAdminTitle.Text = adminChildForm.Text;
        }

        private void buttonAdminInfo_Click(object sender, EventArgs e)
        {
            buttonAdminInfo.BackColor = Color.Firebrick;
            AdminOpenChildForm(new FormAdminInfo());
        }

        private void buttonAdminClients_Click(object sender, EventArgs e)
        {
            buttonAdminClients.BackColor = Color.Firebrick;
            AdminOpenChildForm(new FormAdminClients());
        }

        private void buttonAdminOrder_Click(object sender, EventArgs e)
        {
            buttonAdminOrder.BackColor = Color.Firebrick;
            AdminOpenChildForm(new FormAdminOrder());
        }

        private void buttonAdminHistory_Click(object sender, EventArgs e)
        {
            buttonAdminHistory.BackColor = Color.Firebrick;
            AdminOpenChildForm(new FormAdminHistory());
        }

        private void buttonAdminInfo_Leave(object sender, EventArgs e)
        {
            buttonAdminInfo.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void buttonAdminClients_Leave(object sender, EventArgs e)
        {
            buttonAdminClients.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void buttonAdminOrder_Leave(object sender, EventArgs e)
        {
            buttonAdminOrder.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void buttonAdminHistory_Leave(object sender, EventArgs e)
        {
            buttonAdminHistory.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void buttonAdminSimulation_Click(object sender, EventArgs e)
        {
            buttonAdminSimulation.BackColor = Color.Firebrick;
            AdminOpenChildForm(new FormAdminSimulation());
        }

        private void buttonAdminSimulation_Leave(object sender, EventArgs e)
        {
            buttonAdminSimulation.BackColor = Color.FromArgb(51, 51, 76);
        }
    }
}
