using Gasstation.Resources.Scripts;
using Newtonsoft.Json;
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
    public partial class FormTuck : Form
    {
        SqlFunction sf = new SqlFunction();
        Account ac = new Account();
        DataTable dataStation = new DataTable();
        DataTable dataFuel = new DataTable();
        DataTable dataPriceFuel = new DataTable();
        Card card = new Card();
        public FormTuck()
        {
            InitializeComponent();
        }

        public FormTuck(Account ac)
        {
            InitializeComponent();
            this.ac = ac;
            card.Update(ac.Id);

            //MessageBox.Show(card.View_card[1]);
        }

        private void comboBoxStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxColumns.Items.Clear();
            comboBoxColumns.ResetText();
            comboBoxFuel.Items.Clear();
            comboBoxFuel.ResetText();
            SetColumns();
        }

        private void FormTuck_Load(object sender, EventArgs e)
        {
            SetStation();
            dataPriceFuel = sf.GetPriceFuel();
        }

        private void SetStation()
        {
            
            dataStation = sf.GetStation();

            for (int i = 0; i < dataStation.Rows.Count; i++)
            {
                comboBoxStations.Items.Add(dataStation.Rows[i][0]);
            }
        }

        private void SetColumns()
        {
            comboBoxColumns.Items.Clear();
            int columns = Convert.ToInt32(dataStation.Rows[comboBoxStations.SelectedIndex][1]);
            for (int i = 1; i <= columns; i++)
            {
                comboBoxColumns.Items.Add(i);
            }
            comboBoxColumns.Visible = true;
        }

        private void SetType()
        {
            comboBoxFuel.Items.Clear();
            dataFuel = sf.GetFuel(comboBoxStations.SelectedItem.ToString());
            for (int i = 0; i < dataFuel.Rows.Count; i++)
            {
                comboBoxFuel.Items.Add(dataFuel.Rows[i][1]);
            }
            comboBoxFuel.Visible = true;
        }

        private void comboBoxColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFuel.Items.Clear();
            comboBoxFuel.ResetText();
            SetType();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            CreateTransaction();
            if(!checkBoxWriteOffBonus.Checked)
            {
                string bonus = (Convert.ToDouble(labelPrice.Text) * 2 / 100).ToString();
                sf.AddBonus(ac.Id, bonus);
            }
        }

        private void textBoxLiter_TextChanged(object sender, EventArgs e)
        {
            SetPrice();      
            SetCard();
            comboBoxCard.Visible = true;
        }


        private void SetPrice()
        {
            double price = 0;


            DataRow[] temp;
            temp = dataPriceFuel.Select("type = '" + comboBoxFuel.SelectedItem.ToString() + "'");
            for (int i = 0; i < temp.Length; i++)
            {
                price = Convert.ToDouble(temp[i][2]);
            }


            try
            {
                labelPrice.Text = (price * Convert.ToDouble(textBoxLiter.Text)).ToString();
            }
            catch (Exception)
            {

                labelPrice.Text = (price * 0).ToString();
            }
        }

        private void comboBoxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPrice();
            textBoxLiter.Visible = true;
        }

        private void CreateTransaction()
        {
            string sale = "0";
            string bonus = "0";
            string fuelType = comboBoxFuel.SelectedItem.ToString();
            string countLiter = textBoxLiter.Text;
            string numberStation = comboBoxStations.SelectedItem.ToString();
            string sumShop = labelPrice.Text;
            string numberColumns = comboBoxColumns.SelectedItem.ToString();
            if(comboBoxCard.SelectedItem.ToString() == "дисконтная карта")
            {
                sale = card.Sale[comboBoxCard.SelectedIndex];
                sumShop = labelPriceSale.Text;
            }
                
            else
            {

                if (checkBoxWriteOffBonus.Checked)
                {
                    bonus = card.Count_bonus[comboBoxCard.SelectedIndex];
                    sumShop = labelPriceSale.Text;
                }
                    
            }
                
            sf.CreateTransaction(ac.Id, fuelType, countLiter, numberStation, numberColumns, sumShop, bonus, sale);

        }

        private void SetCard()
        {
            comboBoxCard.Items.Clear();
            for (int i = 0; i < card.View_card.Count; i++)
            {
                comboBoxCard.Items.Add(card.View_card[i]);
            }
        }

        private void comboBoxCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxCard.SelectedItem.ToString() == "дисконтная карта")
            {
                labelBonus.Text = card.Sale[comboBoxCard.SelectedIndex].ToString() + "%";
                labelPriceSale.Text = (Convert.ToDouble(labelPrice.Text) - Convert.ToDouble(labelPrice.Text) * Convert.ToDouble(card.Sale[comboBoxCard.SelectedIndex]) / 100).ToString();
            }
            else
            {
                labelBonus.Text = card.Count_bonus[comboBoxCard.SelectedIndex].ToString() + " бонусов";
                checkBoxWriteOffBonus.Visible = true;
            }
        }

        private void checkBoxWriteOffBonus_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxWriteOffBonus.Checked)
            {
                labelPriceSale.Text = (Convert.ToDouble(labelPrice.Text) - Convert.ToDouble(card.Count_bonus[comboBoxCard.SelectedIndex])).ToString();
            }
        }
    }
}
