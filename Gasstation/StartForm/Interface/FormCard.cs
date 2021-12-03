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
    public partial class FormCard : Form
    {
        Account ac = new Account();
        public FormCard()
        {
            InitializeComponent();
        }

        public FormCard(Account ac)
        {
            InitializeComponent();
            this.ac = ac;
            //MessageBox.Show(ac.Login);
        }
    }
}
