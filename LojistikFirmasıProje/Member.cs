using System;
using System.Collections.Generic;
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
        #region Constructer Method
        public Member(string id,string name, string departman, string iletisim, string maas)
        {
            ID = id;
            AdSoyad = name;
            Departman = departman;
            Iletisim = iletisim;
            Maas = maas;
        }
        #endregion
        #region File Name
        static string filename = "Members.txt";
        #endregion
        #region Methods
        public static List<Member> LoadMembers()
        {
            List<Member> memberList = new List<Member>();
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] split = line.Split(';');
                Member member = new Member(split[0], split[1], split[2], split[3], split[4]);
                memberList.Add(member);
            }
            return memberList;
        }
        public static void AddMember(string adsoyad, string departman, string iletisim, string maas)
        {
            string id = "0";
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            if (lines.Length == 0) id = "0";
            else
            {
                for (int i = lines.Length - 1; i < lines.Length; i++)
                {
                    string[] split = lines[i].Split(';');
                    id = (int.Parse(split[0]) + 1).ToString();
                }
            }
            string line = $"{id};{adsoyad};{departman};{iletisim};{maas}";
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(line);
            sw.Close();
        }
        public static void DeleteMember(string id)
        {
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            List<Member> memberList = new List<Member>();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(';');
                if (split[0] != id)
                {
                    Member member = new Member(split[0], split[1], split[2], split[3], split[4]);
                    memberList.Add(member);
                }
            }
            StreamWriter clear = new StreamWriter(path);
            clear.Write("");
            clear.Close();
            StreamWriter writeNewDatas = new StreamWriter(path, true);
            foreach (var member in memberList)
            {
                string line = $"{member.ID};{member.AdSoyad};{member.Departman};{member.Iletisim};{member.Maas}";
                writeNewDatas.WriteLine(line);
            }
            writeNewDatas.Close();
        }
        public static void UpdateMember(string id, string adsoyad, string departman, string iletisim, string maas)
        {
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            List<Member> memberList = new List<Member>();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(';');
                if (split[0] != id)
                {
                    Member member = new Member(split[0], split[1], split[2], split[3], split[4]);
                    memberList.Add(member);
                }
                else
                {
                    Member member = new Member(id,adsoyad, departman, iletisim, maas);
                    memberList.Add(member);
                }
            }
            StreamWriter clear = new StreamWriter(path);
            clear.Write("");
            clear.Close();
            StreamWriter writeNewDatas = new StreamWriter(path, true);
            foreach (var member in memberList)
            {
                string line = $"{member.ID};{member.AdSoyad};{member.Departman};{member.Iletisim};{member.Maas}";
                writeNewDatas.WriteLine(line);
            }
            writeNewDatas.Close();

        }
        public static Member FindMember(string id)
        {
            Member aranan = new Member("","","","","");
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] split = line.Split(';');
                if(split[0] == id) aranan = new Member(split[0],split[1],split[2],split[3],split[4]);
            }
            return aranan;
        }
        public static void MakeRaise(double percent)
        {
            List<Member> memberList;
            memberList = Member.LoadMembers();
            List<Member> newMemberList = new List<Member>();
            foreach (var member in memberList)
            {
                member.Maas = (Math.Round(Convert.ToDouble(member.Maas) + (Convert.ToDouble(member.Maas) * (Convert.ToDouble(percent) / 100)),2)).ToString();
            }
            StreamWriter clear = new StreamWriter(filename);
            clear.Write("");
            clear.Close();
            StreamWriter sw = new StreamWriter(filename,true);
            foreach (var member in memberList)
            {
                sw.WriteLine($"{member.ID};{member.AdSoyad};{member.Departman};{member.Iletisim};{member.Maas}");
            }
            sw.Close();
        }
        public static void MakeRaiseToPerson(int percent,string id)
        {
            List<Member> memberList;
            memberList = Member.LoadMembers();
            foreach (Member member in memberList)
            {
                if (member.ID == id) member.Maas = (Math.Round(Convert.ToDouble(member.Maas) + (Convert.ToDouble(member.Maas) * (Convert.ToDouble(percent) / 100)), 2)).ToString();
            }
            StreamWriter clear = new StreamWriter(filename);
            clear.Write("");
            clear.Close();
            StreamWriter sw = new StreamWriter(filename, true);
            foreach (var member in memberList)
            {
                sw.WriteLine($"{member.ID};{member.AdSoyad};{member.Departman};{member.Iletisim};{member.Maas}");
            }
            sw.Close();
        }
        public static void SalaryDeductionToPerson(int percent,string id)
        {
            List<Member> memberList;
            memberList = Member.LoadMembers();
            foreach (Member member in memberList)
            {
                if(member.ID == id) member.Maas = (Math.Round(Convert.ToDouble(member.Maas) - (Convert.ToDouble(member.Maas) * (Convert.ToDouble(percent) / 100)), 2)).ToString();
            }
            StreamWriter clear = new StreamWriter(filename);
            clear.Write("");
            clear.Close();
            StreamWriter sw = new StreamWriter(filename, true);
            foreach (var member in memberList)
            {
                sw.WriteLine($"{member.ID};{member.AdSoyad};{member.Departman};{member.Iletisim};{member.Maas}");
            }
            sw.Close();
        }
        public static void SalaryDeduction(int percent)
        {
            List<Member> memberList;
            memberList = Member.LoadMembers();
            foreach (Member member in memberList)
            {
                member.Maas = (Math.Round(Convert.ToDouble(member.Maas) - (Convert.ToDouble(member.Maas) * (Convert.ToDouble(percent) / 100)), 2)).ToString();
            }
            StreamWriter clear = new StreamWriter(filename);
            clear.Write("");
            clear.Close();
            StreamWriter sw = new StreamWriter(filename, true);
            foreach (var member in memberList)
            {
                sw.WriteLine($"{member.ID};{member.AdSoyad};{member.Departman};{member.Iletisim};{member.Maas}");
            }
            sw.Close();
        }
        #endregion
    }
}