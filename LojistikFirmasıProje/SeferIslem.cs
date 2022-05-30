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
    public class SeferIslem
    {
        #region Properties
        public string SeferId { get; set; }
        public string Yer { get; set; }
        public string Kategori { get; set; }
        public DateTime Tarih { get; set; }
        public string Sofor { get; set; }
        #endregion
        #region Constructor Method
        public SeferIslem(string seferId, string yer, string kategori, string tarih, string sofor)
        {
            SeferId = seferId;
            Yer = yer;
            Kategori = kategori;
            Tarih = Convert.ToDateTime(tarih);
            Sofor = sofor;
        }
        public SeferIslem()
        {
        }
        #endregion
        static string connectionString = ConnectionString.Get();

        #region Methods
        public static void SeferEkle(string yer,string kategori,string tarih,string sofor)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Seferler(Yer,Kategori,Tarih,Sofor) VALUES(@Yer,@Kategori,@Tarih,@Sofor)";
            command.Parameters.AddWithValue("@Yer", yer);
            command.Parameters.AddWithValue("@Kategori", kategori);
            command.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(tarih));
            command.Parameters.AddWithValue("@Sofor", sofor);
            command.ExecuteNonQuery();
        }
        public static List<SeferIslem> SeferleriGoruntule()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            List<SeferIslem> seferList = new List<SeferIslem>();
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "SELECT * FROM Seferler";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SeferIslem sefer = new SeferIslem(reader["SeferId"].ToString(), reader["Yer"].ToString(), reader["Kategori"].ToString(), reader["Tarih"].ToString(), reader["Sofor"].ToString());
                    seferList.Add(sefer);
                }
                return seferList;
            }
            catch (Exception)
            {
                return seferList;
            }
        }
        public static void SeferSil(string seferno) 
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "DELETE FROM Seferler WHERE SeferId = @SeferId";
                command.Parameters.AddWithValue("@SeferId", int.Parse(seferno));
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
        }
        public static List<SeferIslem> SearchWithExpeditionNumber(string seferno)
        {
            List<SeferIslem> seferList = new List<SeferIslem>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Seferler WHERE SeferId = @SeferId";
            command.Parameters.AddWithValue("@SeferId", seferno);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SeferIslem sefer = new SeferIslem(reader["SeferId"].ToString(), reader["Yer"].ToString(), reader["Kategori"].ToString(), reader["Tarih"].ToString(), reader["Sofor"].ToString());
                seferList.Add(sefer);
            }
            return seferList;
        }
        public static List<SeferIslem> SearchWithDate(string date)
        {                                       
            SqlConnection conn = new SqlConnection(connectionString);
            List<SeferIslem> seferList = new List<SeferIslem>();
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "SELECT * FROM Seferler WHERE Tarih = @Tarih";
                command.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(date));
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SeferIslem sefer = new SeferIslem(reader["SeferId"].ToString(), reader["Yer"].ToString(), reader["Kategori"].ToString(), reader["Tarih"].ToString(), reader["Sofor"].ToString());
                    seferList.Add(sefer);
                }
                return seferList;
            }
            catch (Exception)
            {
                return seferList;
            }

        }
        public static List<SeferIslem> SearchWithPersonalID(string id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            List<SeferIslem> seferList = new List<SeferIslem>();
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "SELECT * FROM Seferler WHERE Sofor = @Sofor";
                command.Parameters.AddWithValue("@Sofor", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SeferIslem sefer = new SeferIslem(reader["SeferId"].ToString(), reader["Yer"].ToString(), reader["Kategori"].ToString(), reader["Tarih"].ToString(), reader["Sofor"].ToString());
                    seferList.Add(sefer);
                }
                return seferList;
            }
            catch (Exception)
            {
                return seferList;
            }
        }
        public static List<SeferIslem> SearchWithLocation(string location)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            List<SeferIslem> seferList = new List<SeferIslem>();
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "SELECT * FROM Seferler WHERE Yer = @Yer";
                command.Parameters.AddWithValue("@Yer", location);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SeferIslem sefer = new SeferIslem(reader["SeferId"].ToString(), reader["Yer"].ToString(), reader["Kategori"].ToString(), reader["Tarih"].ToString(), reader["Sofor"].ToString());
                    seferList.Add(sefer);
                }
                return seferList;
            }
            catch (Exception)
            {
                return seferList;
            }

        }
        public static List<SeferIslem> SearchWithCategory(string category)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            List<SeferIslem> seferList = new List<SeferIslem>();
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "SELECT * FROM Seferler WHERE Kategori = @Kategori";
                command.Parameters.AddWithValue("@Kategori", category);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SeferIslem sefer = new SeferIslem(reader["SeferId"].ToString(), reader["Yer"].ToString(), reader["Kategori"].ToString(), reader["Tarih"].ToString(), reader["Sofor"].ToString());
                    seferList.Add(sefer);
                }
                return seferList;
            }
            catch (Exception)
            {
                return seferList;
            }
        }
        #endregion
    }
}
