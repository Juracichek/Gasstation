using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasstation
{
    public class SqlFunction
    {
        public SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
        
        // Регистрация пользователя
        public bool RegUsers(string name, string password, string email)
        {
            bool flag = false;
            SqlCommand cmd = new SqlCommand($"INSERT INTO [users] (name, password, email) VALUES (@name, @password, @email)", conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);
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
            SqlCommand cmd = new SqlCommand($"SELECT name FROM [users] WHERE name = @name AND password = @password", conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@password", password);
            conn.Open();
            SqlDataReader srd = cmd.ExecuteReader();
            if (srd.HasRows)
            {
                flag = true;
            }
            conn.Close();
            return flag;
        }
    }
}
