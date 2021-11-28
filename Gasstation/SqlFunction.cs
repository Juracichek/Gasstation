using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gasstation
{
    public class SqlFunction
    {
        // Подключение БД
        MySqlConnection conn = new MySqlConnection("server=juryamb8.beget.tech;user=juryamb8_gasstat;password=rOot123;database=juryamb8_gasstat");


        // Регистрация пользователя
        public bool RegUsers(string name, string password, string email, string phone)
        {
            bool flag = false;
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO users (name, password, email, phone) VALUES (@name, @password, @email, @phone)", conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            conn.Open();
            if(cmd.ExecuteNonQuery() == 1)
            {
                flag = true;
            }
            conn.Close();
            return flag;
        }

        // Авторизация пользователя
        public bool LogUsers(string name, string password)
        {
            bool flag = false;
            MySqlCommand cmd = new MySqlCommand($"SELECT name FROM users WHERE name = @name AND password = @password", conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@password", password);
            conn.Open();
            MySqlDataReader srd = cmd.ExecuteReader();
            if (srd.HasRows)
            {
                flag = true;
            }
            conn.Close();
            return flag;
        }
    }
}
