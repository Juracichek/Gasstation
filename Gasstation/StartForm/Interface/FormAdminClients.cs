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
    public partial class FormAdminClients : Form
    {
        SqlFunction sf = new SqlFunction();
        public FormAdminClients()
        {
            InitializeComponent();
        }

        private void FormAdminClients_Load(object sender, System.EventArgs e)
        {
            dgv_AdminClient.Rows.Clear();
            dgv_AdminClient.DataSource = sf.GetAdminClient();
        }
    }
}
