using Gasstation.Resources.Scripts;
using System.Windows.Forms;

namespace Gasstation.StartForm.Interface
{
    public partial class FormHistory : Form
    {
        Account ac = new Account();
        SqlFunction sf = new SqlFunction();
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

        private void FormHistory_Load(object sender, System.EventArgs e)
        {
            dgv_History.Rows.Clear();
            dgv_History.DataSource = sf.GetHistory(ac.Id);
        }
    }
}
