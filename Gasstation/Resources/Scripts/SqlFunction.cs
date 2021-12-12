using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
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
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
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
            var rnd = new Random();
            var id = rnd.Next(1000, 9999);
            var dataShopping = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO shopping (id, id_user, fuel_type, count_liter, number_stations, number_columns, date_shopping, sum_shop, count_score_of_shop, sale) VALUES (@id, @id_user, @fuel_type, @count_liter, @number_stations, @number_columns, @date_shopping, @sum_shop, @count_score_of_shop, @sale)", conn);
            cmd.Parameters.AddWithValue("@id", id);
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
            ChangeFuel(numberStation, fuelType, countLiter, id.ToString());
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

        public ArrayList GetHistory(string id)
        {
            ArrayList list = new ArrayList();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM shopping WHERE id_user = @id_user", conn);
            cmd.Parameters.AddWithValue("@id_user", id);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    list.Add(result);
                }
            }
            conn.Close();
            return list;
        }

        public bool CreateCard(string id, string typeCard)
        {
            bool flag = false;
            string bonus = "0", sale = "0";
            if(typeCard == "дисконтная карта")
            {
                sale = "2";
            }    
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO bonus (id_user, view_card, sale, count_bonus) VALUES (@id_user, @view_card, @sale, @count_bonus)", conn);
            cmd.Parameters.AddWithValue("@id_user", id);
            cmd.Parameters.AddWithValue("@view_card", typeCard);
            cmd.Parameters.AddWithValue("@sale", sale);
            cmd.Parameters.AddWithValue("@count_bonus", bonus);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                flag = true;
            }
            conn.Close();
            return flag;
        }

        public ArrayList GetAdminClient()
        {
            ArrayList list = new ArrayList();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM users", conn);
            //cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    list.Add(result);
                }
            }
            conn.Close();
            return list;
        }

        public ArrayList GetAdminHistory()
        {
            ArrayList list = new ArrayList();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM shopping", conn);
            //cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    list.Add(result);
                }
            }
            conn.Close();
            return list;
        }

        public string GetCountClients()
        {
            string count = "0";
            MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(id) FROM users", conn);
            conn.Open();
            count = cmd.ExecuteScalar().ToString();
            conn.Close();
            return count;
        }

        public string GetCountStation()
        {
            string count = "0";
            MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(number_stations) FROM stations", conn);
            conn.Open();
            count = cmd.ExecuteScalar().ToString();
            conn.Close();
            return count;
        }

        public string GetCountShop()
        {
            string count = "0";
            MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(id) FROM shopping", conn);
            conn.Open();
            count = cmd.ExecuteScalar().ToString();
            conn.Close();
            return count;
        }

        public ArrayList GetAdminFuelPrice()
        {
            ArrayList list = new ArrayList();
            MySqlCommand cmd = new MySqlCommand($"SELECT type, price_per_liter FROM fuel", conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    list.Add(result);
                }
            }
            conn.Close();
            return list;
        }

        public DataTable GetShopPeriod(string dataStart, string dataEnd)
        {
            DataTable data = new DataTable();
            data.Clear();
            MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*), DATE(date_shopping) AS my_date FROM shopping WHERE (date_shopping BETWEEN @dataStart AND @dataEnd) GROUP BY my_date", conn);
            cmd.Parameters.AddWithValue("@dataStart", dataStart);
            cmd.Parameters.AddWithValue("@dataEnd", dataEnd);
            conn.Open();
            MySqlDataReader read = cmd.ExecuteReader();
            data.Load(read);
            conn.Close();
            return data;
        }

        public void ChangeFuel(string idStation, string fuelType, string countLiter, string idShop)
        {
            MySqlCommand command = new MySqlCommand($"INSERT INTO change_fuel (take_liter, id_shopping) VALUES (@take_liter, @id_shopping)", conn);
            command.Parameters.AddWithValue("@take_liter", countLiter);
            command.Parameters.AddWithValue("@id_shopping", idShop);
            MySqlCommand command1 = new MySqlCommand($"UPDATE condition_stations SET count_liter = count_liter - @count_liter WHERE id_station = @id_station AND fuel_type = @fuel_type", conn);
            command1.Parameters.AddWithValue("@id_station", idStation);
            command1.Parameters.AddWithValue("@fuel_type", fuelType);
            command1.Parameters.AddWithValue("@count_liter", countLiter);
            conn.Open();
            command.ExecuteNonQuery();
            command1.ExecuteNonQuery();
            conn.Close();
        }

        public bool OrderFuel(string idStation, string fuelType, string countLiter)
        {
            bool flag = false;
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO fuel_order (number_stations, fuel_type, count_liter) VALUES (@number_stations, @fuel_type, @count_liter)", conn);
            cmd.Parameters.AddWithValue("@number_stations", idStation);
            cmd.Parameters.AddWithValue("@fuel_type", fuelType);
            cmd.Parameters.AddWithValue("@count_liter", countLiter);
            MySqlCommand cmd1 = new MySqlCommand($"UPDATE condition_stations SET count_liter = count_liter + @count_liter WHERE id_station = @id_station AND fuel_type = @fuel_type", conn);
            cmd1.Parameters.AddWithValue("@id_station", idStation);
            cmd1.Parameters.AddWithValue("@fuel_type", fuelType);
            cmd1.Parameters.AddWithValue("@count_liter", countLiter);
            conn.Open();
            if(cmd.ExecuteNonQuery() == 1 && cmd1.ExecuteNonQuery() == 1)
            {
                flag = true;
            }
            conn.Close();
            return flag;
        }
    }
}
