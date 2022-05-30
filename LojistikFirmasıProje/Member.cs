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
    public class Member
    {
        #region Properties
        public string ID { get; set; }
        public string AdSoyad { get; set; }
        public string Iletisim { get; set; }
        public string Departman { get; set; }
        public string Maas { get; set; }
        #endregion
        static string connectionString = ConnectionString.Get();
        #region Constructer Method
        public Member(string id,string name, string departman, string iletisim, string maas)
        {
            ID = id;
            AdSoyad = name;
            Departman = departman;
            Iletisim = iletisim;
            Maas = maas;
        }
        public Member()
        {
        }
        #endregion
        #region Methods
        public static List<Member> LoadMembers()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            List<Member> memberList = new List<Member>();
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Uyeler";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Member uye = new Member(reader["MemberId"].ToString(),reader["AdSoyad"].ToString(),reader["Departman"].ToString(),reader["Iletisim"].ToString(),reader["Maas"].ToString());
                memberList.Add(uye);
            }
            return memberList;
        }
        public static void AddMember(string adsoyad, string departman, string iletisim, string maas)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Uyeler(AdSoyad,Departman,Iletisim,Maas) VALUES(@AdSoyad,@Departman,@Iletisim,@Maas)";
            command.Parameters.AddWithValue("@AdSoyad", adsoyad);
            command.Parameters.AddWithValue("@Departman", departman);
            command.Parameters.AddWithValue("@Iletisim", iletisim);
            command.Parameters.AddWithValue("@Maas", decimal.Parse(maas));
            command.ExecuteNonQuery();
        }
        public static void DeleteMember(string id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "DELETE FROM Uyeler WHERE MemberId = @Id";
                command.Parameters.AddWithValue("@Id", int.Parse(id));
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
        }
        public static void UpdateMember(string id, string adsoyad, string departman, string iletisim, string maas)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "UPDATE Uyeler SET AdSoyad = @AdSoyad, Departman = @Departman, Iletisim = @Iletisim, Maas = @Maas WHERE MemberId = @Id";
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@AdSoyad", adsoyad);
                command.Parameters.AddWithValue("@Departman", departman);
                command.Parameters.AddWithValue("@Iletisim", iletisim);
                command.Parameters.AddWithValue("@Maas", decimal.Parse(maas));
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
        }
        public static Member FindMember(string id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            Member uye = new Member();
            try
            {
                command.CommandText = "SELECT * FROM Uyeler WHERE MemberId = @MemberId";
                command.Parameters.AddWithValue("@MemberId", int.Parse(id));
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    uye = new Member(reader["MemberId"].ToString(), reader["AdSoyad"].ToString(), reader["Departman"].ToString(), reader["Iletisim"].ToString(), reader["Maas"].ToString());
                }
                return uye;
            }
            catch (Exception)
            {
                return uye;
            }
        }
        public static void MakeRaise(double percent)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            List<Member> memberList = Member.LoadMembers();
            foreach (var member in memberList)
            {
                double yenimaas = double.Parse(member.Maas) + (double.Parse(member.Maas) * (percent / 100));
                command.CommandText = $"UPDATE Uyeler SET Maas = @Maas WHERE MemberId = '{member.ID}'";
                command.Parameters.AddWithValue("@Maas", yenimaas);
            }
            command.ExecuteNonQuery();
        }
        public static void MakeRaiseToPerson(int percent,string id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            List<Member> memberList = Member.LoadMembers();
            Member member = memberList.FirstOrDefault(x => x.ID == id);
            double yenimaas = double.Parse(member.Maas) + (double.Parse(member.Maas) * (percent / 100));
            SqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "UPDATE Uyeler SET Maas = @Maas WHERE MemberId = @Id";
                command.Parameters.AddWithValue("@MemberId", member.ID);
                command.Parameters.AddWithValue("@Maas", yenimaas);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
        }
        public static void SalaryDeductionToPerson(int percent,string id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            List<Member> memberList = Member.LoadMembers();
            Member member = memberList.FirstOrDefault(x => x.ID == id);
            double yenimaas = double.Parse(member.Maas) - (double.Parse(member.Maas) * (percent / 100));
            SqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "UPDATE Uyeler SET Maas = @Maas WHERE MemberId = @Id";
                command.Parameters.AddWithValue("@MemberId", member.ID);
                command.Parameters.AddWithValue("@Maas", yenimaas);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }

        }
        public static void SalaryDeduction(int percent)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            List<Member> memberList = Member.LoadMembers();
            foreach (var member in memberList)
            {
                double yenimaas = double.Parse(member.Maas) - (double.Parse(member.Maas) * (percent / 100));
                command.CommandText = "UPDATE Uyeler SET Maas = @Maas WHERE MemberId = @Id";
                command.Parameters.AddWithValue("@MemberId", member.ID);
                command.Parameters.AddWithValue("@Maas", yenimaas);
                command.ExecuteNonQuery();
            }
        }
        #endregion
    }
}