using Gasstation.Resources.Scripts;
using System.Windows.Forms;

namespace Gasstation.StartForm.Interface
{
    public partial class FormHistory : Form
    {
        Account ac = new Account();
        public FormHistory()
        {
            InitializeComponent();
        }

        public FormHistory(Account ac)
        {
            InitializeComponent();
            this.ac = ac;
            //MessageBox.Show(ac.Login);
        }
    }
}
