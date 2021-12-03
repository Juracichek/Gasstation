using Gasstation.Resources.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasstation.StartForm.Interface
{
    public partial class FormProfile : Form
    {
        Account ac = new Account();

        public FormProfile()
        {
            InitializeComponent();
        }

        public FormProfile(Account ac)
        {
            InitializeComponent();
            this.ac = ac;
            //essageBox.Show(ac.Login);
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            labelNameDB.Text = "Здравствуйте, " + ac.Login;
        }
    }
}
