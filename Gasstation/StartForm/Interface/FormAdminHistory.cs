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
    public partial class FormAdminHistory : Form
    {
        SqlFunction sf = new SqlFunction();
        public FormAdminHistory()
        {
            InitializeComponent();
        }

        private void FormAdminHistory_Load(object sender, EventArgs e)
        {
            dgv_AdminHistory.Rows.Clear();
            dgv_AdminHistory.DataSource = sf.GetAdminHistory();
        }
    }
}
