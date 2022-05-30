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
    class Appoitment
    {
        #region Properties
        public string Tur { get; set; }
        public DateTime Tarih { get; set; }
        public string Konu { get; set; }
        public Onem Onem { get; set; }
        #endregion
        #region Constructor Method
        public Appoitment(string tur, string tarih, string konu, Onem onem)
        {
            Tur = tur;
            Tarih = Convert.ToDateTime(tarih);
            Konu = konu;
            Onem = onem;
        }
        #endregion
        static string connectionString = ConnectionString.Get();
        #region Methods
        public static List<Appoitment> LoadAppointmens()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            List<Appoitment> randevuList = new List<Appoitment>();
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Gorusmeler";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Appoitment appointment = new Appoitment(reader["Tur"].ToString(), reader["Tarih"].ToString(), reader["Konu"].ToString(), (Onem)(int.Parse(reader["Onem"].ToString())));
                randevuList.Add(appointment);
            }
            return randevuList;
        }
        public static void AddAppointment(string tur, DateTime tarih, string konu, int onem)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Gorusmeler(Tur,Tarih,Konu,Onem) VALUES(@Tur,@Tarih,@Konu,@Onem)";
            command.Parameters.AddWithValue("@Tur", tur);
            command.Parameters.AddWithValue("@Tarih", tarih);
            command.Parameters.AddWithValue("@Konu", konu);
            command.Parameters.AddWithValue("@Onem", onem);
            command.ExecuteNonQuery();
        }
        #endregion
    }
}
