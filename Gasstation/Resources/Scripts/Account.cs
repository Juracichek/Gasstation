using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasstation.Resources.Scripts
{
    public class Account
    {
        public string Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


        public Account()
        {
        }

        public void Get()
        {
            //MessageBox.Show(Email);
        }

    }

    public class Card
    {
        SqlFunction sf = new SqlFunction();
        public List<string> View_card { get; set; }
        public List<string> Sale { get; set; }
        public List<string> Count_bonus { get; set; }

        public Card()
        {
            View_card = new List<string>();
            Sale = new List<string>();
            Count_bonus = new List<string>();
        }

        public void Update(string id)
        {

            Clear();
            DataTable dateCard = new DataTable();
            dateCard = sf.GetCard(id);
            for (int i = 0; i < dateCard.Rows.Count; i++)
            {
                View_card.Add(dateCard.Rows[i][2].ToString());
                Sale.Add(dateCard.Rows[i][3].ToString());
                Count_bonus.Add(dateCard.Rows[i][4].ToString());
            }
        }

        public void Clear()
        {
            View_card.Clear();
            Sale.Clear();
            Count_bonus.Clear();
        }
    }

    

}
