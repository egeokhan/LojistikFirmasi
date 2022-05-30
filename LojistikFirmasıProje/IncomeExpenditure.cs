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
    public class IncomeExpenditure
    {
        #region Properties
        public string Tur { get; set; }
        public GelirGider GelirGider { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Miktar { get; set; }
        #endregion
        static string connectionString = ConnectionString.Get();
        #region Constructor Method
        public IncomeExpenditure(string tur, GelirGider gelirGider, DateTime tarih, decimal miktar)
        {
            Tur = tur;
            GelirGider = gelirGider;
            Tarih = tarih;
            Miktar = miktar;
        }
        #endregion
        #region Methods
        public static List<IncomeExpenditure> LoadDatas()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            List<IncomeExpenditure> ieList = new List<IncomeExpenditure>();
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM GelirGider";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                IncomeExpenditure iE = new IncomeExpenditure(reader["Tur"].ToString(),(GelirGider)int.Parse(reader["GelirGider"].ToString()),Convert.ToDateTime(reader["Tarih"].ToString()),Convert.ToDecimal(reader["Miktar"].ToString()));
                ieList.Add(iE);
            }
            return ieList;
        }
        public static void GiveSalary()
        {
            List<Member> memberList = Member.LoadMembers();
            decimal miktar = memberList.Sum(m => decimal.Parse(m.Maas));
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO GelirGider(Tur,GelirGider,Tarih,Miktar) VALUES(@Tur,@GelirGider,@Tarih,@Miktar)";
            command.Parameters.AddWithValue("@Tur", "Toplu Maaş");
            command.Parameters.AddWithValue("@GelirGider", 1);
            command.Parameters.AddWithValue("@Tarih", DateTime.Now.Date);
            command.Parameters.AddWithValue("@Miktar", miktar);
            command.ExecuteNonQuery();
        }
        public static void GelirEkle(string tur,DateTime tarih,int miktar)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO GelirGider(Tur,GelirGider,Tarih,Miktar) VALUES(@Tur,@GelirGider,@Tarih,@Miktar)";
            command.Parameters.AddWithValue("@Tur", tur);
            command.Parameters.AddWithValue("@GelirGider", 0);
            command.Parameters.AddWithValue("@Tarih", tarih);
            command.Parameters.AddWithValue("@Miktar", miktar);
            command.ExecuteNonQuery();
        }
        public static void GiderEkle(string tur, DateTime tarih, int miktar)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO GelirGider(Tur,GelirGider,Tarih,Miktar) VALUES(@Tur,@GelirGider,@Tarih,@Miktar)";
            command.Parameters.AddWithValue("@Tur", tur);
            command.Parameters.AddWithValue("@GelirGider", 1);
            command.Parameters.AddWithValue("@Tarih", tarih);
            command.Parameters.AddWithValue("@Miktar", miktar);
            command.ExecuteNonQuery();
        }
        #endregion
    }
}