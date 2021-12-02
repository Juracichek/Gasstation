using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasstation
{
    public partial class Simulation : Form
    {
        SqlFunction sf = new SqlFunction();
        private bool Working;

        public Simulation()
        {
            InitializeComponent();
        }
        
        string[] logins = 
            {
                "Ylliange", "Dennaghe", "Quelando", "Rvidana", "Haziyatt", "Silvi", "Quitoka", "Matt", "Dann", "Slinte",
                "Apin", "Grgekama", "Vil", "Bemmol", "Nnari", "Qatokorr", "Warea", "Dane", "Debrta", "Canoleny", "Xynam",
                "Janshit", "Fengru", "Elays", "Gayra", "Quntah", "Gie", "Nelitust", "Varigari", "Envaip", "Kadim", "Zal", 
                "Quronch"
            };
        string[] passwords = 
            {
                "faUtmX", "sn57cO", "h1LqY1", "QRcNMH", "NKvkfI", "tV5Z3i", "fLff50", "vJXcJ4", "KZ91Wt", "R0MqIL", "BVJxhU",
                "eJBuPG", "olP9yY", "RxuPwO", "3CH8eK", "WeCQy5", "rLQ3Ta", "eKDhx2", "5Rszqj", "XBK7zU", "LoKQoG", "gxnzjd",
                "S8YiK7", "CjdoUF", "k0JkHv", "7vBWUB", "wfZFuO", "OxEODo", "hLPKiG", "D8SV2A", "5ByzlA", "d43XbX", "IdzO71"
            };
        string[] phons = 
            {
                "108-44-09", "398-39-84", "780-52-45", "279-01-99", "525-58-70", "853-65-47", "215-56-13", "877-33-27", "255-46-10", "111-99-52", "485-55-26",
                "286-47-59", "378-32-38", "342-86-15", "446-28-30", "347-98-12", "225-79-85", "142-93-00", "566-35-59", "957-06-37", "826-48-52", "733-68-16",
                "541-72-44", "523-49-15", "358-43-08", "942-43-49", "415-25-83", "932-97-43", "274-79-00", "615-93-57", "230-02-00", "853-89-85", "576-58-35"
            };
        string[] emails = 
            {
                "frekillouttecu-8762@yopmail.com", "bricrouttennoze-9612@yopmail.com", "44dc1ffm@yandex.ru", "5ybwi@mail.ru", "pvvxl@gmail.com", "kc29hc0e@yandex.ru", "myrfqpb@mail.ru", "copaa6@gmail.com", "n4zc9kz@yandex.ru", "q4aptu@mail.ru", "xl9bc5@gmail.com",
                "ahbg@yandex.ru", "p24a@mail.ru", "f9jxjd14@gmail.com", "oxxv@yandex.ru", "kggfpxw@yandex.ru", "aojv@mail.ru", "taceg41968@slvlog.com", "nigellegin@emvil.com", "o@outlook.com", "hr6zdl@yandex.ru", "kaft93x@outlook.com",
                "dcu@yandex.ru", "19dn@outlook.com", "pa5h@mail.ru", "281av0@gmail.com", "8edmfh@outlook.com", "sfn13i@mail.ru", "g0orc3x1@outlook.com", "rv7bp@gmail.com", "rv7bp@gmail.com", "er@gmail.com", "o0my@gmail.com"
            };

        Random random = new Random();
        int count = 0; // счётчик для регистрации

        public void Registration()
        {
            while(Working)
            { 
                string login = logins[random.Next(0, logins.Length)] + random.Next(10000, 99999);
                string password = passwords[random.Next(0, passwords.Length)];
                string phone = phons[random.Next(0, phons.Length)];
                string email = emails[random.Next(0, emails.Length)];
                sf.RegUsers(login, password, phone, email);
                count++;
                label1.Invoke(new Action(() => label1.Text = count.ToString()));
                Thread.Sleep(1000);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Working = true;
            Task.Run(() => Registration());
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Working = false;
        }
    }
}
