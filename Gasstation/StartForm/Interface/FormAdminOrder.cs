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
    public partial class FormAdminOrder : Form
    {
        SqlFunction sf = new SqlFunction();
        DataTable dataStation = new DataTable();
        DataTable dataFuel = new DataTable();
        DataTable dataPriceFuel = new DataTable();
        public FormAdminOrder()
        {
            InitializeComponent();
        }

        private void SetStation()
        {

            dataStation = sf.GetStation();

            for (int i = 0; i < dataStation.Rows.Count; i++)
            {
                comboBoxAdminStations.Items.Add(dataStation.Rows[i][0]);
            }
        }

        private void SetType()
        {
            comboBoxAdminFuel.Items.Clear();
            dataFuel = sf.GetFuel(comboBoxAdminStations.SelectedItem.ToString());
            for (int i = 0; i < dataFuel.Rows.Count; i++)
            {
                comboBoxAdminFuel.Items.Add(dataFuel.Rows[i][1]);
            }
            labelTypeFuel.Visible = true;
            comboBoxAdminFuel.Visible = true;
        }

        private void FormAdminOrder_Load(object sender, EventArgs e)
        {
            SetStation();
        }

        private void comboBoxAdminStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetType();
        }

        private void buttonAdminOrder_Click(object sender, EventArgs e)
        {
            if(sf.OrderFuel(comboBoxAdminStations.SelectedItem.ToString(), comboBoxAdminFuel.SelectedItem.ToString(), textBoxAdminLiter.Text))
            {
                //оформить
                MessageBox.Show("Заказ оформлен");
            }
            
        }
    }
}
