using Gasstation.StartForm.Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gasstation
{
    public partial class Interface : Form
    {
        private Button currentButton;
        private Form activeForm;

        public Interface()
        {
            InitializeComponent();
        }
                
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Firebrick;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previosBtn in panelMenu.Controls)
            {
                if(previosBtn.GetType() == typeof(Button))
                {
                    previosBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previosBtn.ForeColor = Color.Gainsboro;
                    previosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
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
            ActivateButton(sender);
            OpenChildForm(new FormProfile(), sender);
        }

        private void buttonTuck_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormTuck(), sender);
        }

        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormDelivery(), sender);
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormHistory(), sender);
        }
    }
}
