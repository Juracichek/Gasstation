using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gasstation
{
    public class SqlFunction
    {
        // Подключение БД
        MySqlConnection conn = new MySqlConnection("server=juryamb8.beget.tech;user=juryamb8_gasstat;password=rOot123;database=juryamb8_gasstat");


        // Регистрация пользователя
        public bool RegUsers(string login, string password, string phone, string email)
        {
            bool flag = false;
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO users (login, password, phone, email) VALUES (@login, @password, @phone, @email)", conn);
            cmd.Parameters.AddWithValue("@login", login);
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
        public bool LogUsers(string login, string password)
        {
            bool flag = false;
            MySqlCommand cmd = new MySqlCommand($"SELECT login FROM users WHERE login = @login AND password = @password", conn);
            cmd.Parameters.AddWithValue("@login", login);
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

        //  Получаем данные о клиенте, который авторизировался
        public DataTable GetClient(string login)
        {
            DataTable data = new DataTable();
            data.Clear();
            string sql = String.Format("SELECT * FROM users WHERE login = @uLogin ");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = login;
            conn.Open();
            MySqlDataReader sqldr = cmd.ExecuteReader();
            data.Load(sqldr);

            conn.Close();
            return data;
        }

        public DataTable GetStation()
        {
            DataTable data = new DataTable();
            string sql = String.Format("SELECT * FROM stations");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader sqldr = cmd.ExecuteReader();
            data.Load(sqldr);
            conn.Close();
            return data;
        }

        public DataTable GetFuel(string numberStation)
        {
            DataTable data = new DataTable();
            string sql = String.Format("SELECT * FROM condition_stations WHERE id_station = @id_station");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@id_station", MySqlDbType.VarChar).Value = numberStation;
            conn.Open();
            MySqlDataReader sqldr = cmd.ExecuteReader();
            data.Load(sqldr);
            conn.Close();
            return data;
        }

        public DataTable GetPriceFuel()
        {
            DataTable data = new DataTable();
            string sql = String.Format("SELECT * FROM fuel");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader sqldr = cmd.ExecuteReader();
            data.Load(sqldr);
            conn.Close();
            return data;
        }

        public bool CreateTransaction(string idUser, string fuelType, string countLiter, string numberStation, string numberColumns, string sumShop, string countBonus, string sale)
        {
            bool flag = false;
            var dataShopping = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO shopping (id_user, fuel_type, count_liter, number_stations, number_columns, date_shopping, sum_shop, count_score_of_shop, sale) VALUES (@id_user, @fuel_type, @count_liter, @number_stations, @number_columns, @date_shopping, @sum_shop, @count_score_of_shop, @sale)", conn);
            cmd.Parameters.AddWithValue("@id_user", idUser);
            cmd.Parameters.AddWithValue("@fuel_type", fuelType);
            cmd.Parameters.AddWithValue("@count_liter", countLiter);
            cmd.Parameters.AddWithValue("@number_stations", numberStation);
            cmd.Parameters.AddWithValue("@number_columns", numberColumns);
            cmd.Parameters.AddWithValue("@date_shopping", dataShopping);
            cmd.Parameters.AddWithValue("@sum_shop", sumShop);
            cmd.Parameters.AddWithValue("@count_score_of_shop", countBonus);
            cmd.Parameters.AddWithValue("@sale", sale);
            MySqlCommand command = new MySqlCommand($"UPDATE bonus SET count_bonus = count_bonus - @count_bonus WHERE id_user = @id_user AND view_card = @view_card", conn);
            command.Parameters.AddWithValue("@id_user", idUser);
            command.Parameters.AddWithValue("@count_bonus", countBonus);
            command.Parameters.AddWithValue("@view_card", "бонусная карта");
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1 && command.ExecuteNonQuery() == 1)
            {
                flag = true;
            }
            conn.Close();
            return flag;
        }

        public DataTable GetCard(string idUser)
        {
            DataTable data = new DataTable();
            string sql = String.Format("SELECT * FROM bonus WHERE id_user = @id_user");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@id_user", MySqlDbType.VarChar).Value = idUser;
            conn.Open();
            MySqlDataReader sqldr = cmd.ExecuteReader();
            data.Load(sqldr);
            conn.Close();
            return data;
        }

        public bool AddBonus(string id, string bonus)
        {
            bool flag = false;
            MySqlCommand command = new MySqlCommand($"UPDATE bonus SET count_bonus = count_bonus + @count_bonus WHERE id_user = @id_user AND view_card = @view_card", conn);
            MessageBox.Show(bonus);
            command.Parameters.AddWithValue("@id_user", id);
            command.Parameters.AddWithValue("@count_bonus", bonus);
            command.Parameters.AddWithValue("@view_card", "бонусная карта");
            conn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
            }
            conn.Close();
            return flag;
        }
    }
}
