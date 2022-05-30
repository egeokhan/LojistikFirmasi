using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojistikFirmasıProje
{
    public class User
    {
        #region Variables
        public string Username { get; set; }
        public string Password { get; set; }
        #endregion
        #region Constructer Method
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
        #endregion
        static string connectionString = ConnectionString.Get();
        #region Methods
        public bool GirisKontrol(User kullanici)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Giris";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User veridekiKullanici = new User(reader["KullaniciAdi"].ToString(), reader["Sifre"].ToString());
                if (veridekiKullanici.Username == kullanici.Username && veridekiKullanici.Password == kullanici.Password)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
