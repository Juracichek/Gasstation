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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (sf.Update(textBoxID.Text, textBoxLogin.Text, textBoxPass.Text, textBoxEmail.Text, textBoxPhone.Text))
            {
                MessageBox.Show("Запись успешно изменена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if(sf.RegUsers(textBoxLogin.Text, textBoxPass.Text, textBoxPhone.Text, textBoxEmail.Text))
            {
                MessageBox.Show("Новая запись успешно добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if(sf.Del(textBoxID.Text))
            {
                MessageBox.Show("Запись успешно удалена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
