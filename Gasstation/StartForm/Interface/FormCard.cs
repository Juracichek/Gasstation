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
        Card card = new Card();
        SqlFunction sf = new SqlFunction();
        public FormCard()
        {
            InitializeComponent();
        }

        public FormCard(Account ac)
        {
            InitializeComponent();
            this.ac = ac;
            card.Update(ac.Id);
            //MessageBox.Show(ac.Login);
        }

        private void FormCard_Load(object sender, EventArgs e)
        {
            if (card.View_card.Count == 2)
            {
                labelViewCard.Text = (card.View_card[0]).ToString();
                labelViewCard1.Text = (card.View_card[1]).ToString();
                TypeViewCard(2);
            }
            else if (card.View_card.Count == 1)
            {
                labelViewCard.Text = (card.View_card[0]).ToString();
                TypeViewCard(1);
            }
            else 
            {
                labelViewCard.Text = "У вас нет карты";
                TypeViewCard(0);
            }

            //MessageBox.Show(card.View_card.Count.ToString());
        }

        private void TypeViewCard(int count)
        {
            if(count == 2)
            {
                if (labelViewCard.Text == "бонусная карта")
                {
                    labelCountSale.Text = card.Sale[1].ToString() + " %";
                    labelCountBon.Text = card.Count_bonus[0].ToString() + " бон.";
                }
                else
                {
                    labelCountSale.Text = card.Count_bonus[1].ToString() + " бон.";
                    labelCountBon.Text = card.Sale[0].ToString() + " %"; 
                }
                    
            }
            else if (count == 1)
            {
                if (labelViewCard.Text == "бонусная карта")
                {
                    labelCountBon.Text = card.Count_bonus[0].ToString() + " бон.";
                    comboBoxSelectCard.Items.Add("дисконтная карта");
                }
                else
                {
                    labelCountBon.Text = card.Sale[0].ToString() + " %";
                    comboBoxSelectCard.Items.Add("бонусная карта");
                }
                buttonCheckoutCard.Visible = true;
                comboBoxSelectCard.Visible = true;
            }
            else
            {
                comboBoxSelectCard.Items.Add("дисконтная карта");
                comboBoxSelectCard.Items.Add("бонусная карта");
                buttonCheckoutCard.Visible = true;
                comboBoxSelectCard.Visible = true;
            }
            
        }

        private void buttonCheckoutCard_Click(object sender, EventArgs e)
        {
            sf.CreateCard(ac.Id, comboBoxSelectCard.SelectedItem.ToString());
        }
    }
}
