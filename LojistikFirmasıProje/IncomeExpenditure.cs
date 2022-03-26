using System;
using System.Collections.Generic;
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
        public int Miktar { get; set; }
        #endregion
        #region Constructor Method
        public IncomeExpenditure(string tur, GelirGider gelirGider, DateTime tarih, int miktar)
        {
            Tur = tur;
            GelirGider = gelirGider;
            Tarih = tarih;
            Miktar = miktar;
        }
        #endregion
        #region File Name
        static string filename = "GelirGider.txt";
        #endregion
        #region Methods
        public static List<IncomeExpenditure> LoadDatas()
        {
            List<IncomeExpenditure> ieList = new List<IncomeExpenditure>();
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(';');
                IncomeExpenditure ie = new IncomeExpenditure(split[0], (GelirGider)int.Parse(split[1]), Convert.ToDateTime(split[2]), int.Parse(split[3]));
                ieList.Add(ie);
            }
            return ieList;
        }
        public static void GiveSalary()
        {
            List<Member> memberList = Member.LoadMembers();
            int miktar = memberList.Sum(m => int.Parse(m.Maas));
            StreamWriter sw = new StreamWriter(filename, true);
            sw.WriteLine($"Toplu Maaş;1;{DateTime.Now.Date};{miktar}");
            sw.Close();
        }
        #endregion
    }
}