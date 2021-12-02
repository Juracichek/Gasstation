using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasstation
{
    public partial class Interface : Form
    {
        private Button currentButton;
        private int tempIndex;
        private Form activeForm;

        public Interface()
        {
            InitializeComponent();
        }
                


        private void OpenChildForm(Form childForm, object btnSender)
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
            OpenChildForm(new FormProfile(), sender);
        }

        private void buttonTuck_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            
        }
    }
}
