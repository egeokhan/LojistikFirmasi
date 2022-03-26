using System;
using System.Collections.Generic;
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
        public string SeferNo { get; set; }
        public string Yer { get; set; }
        public string Kategori { get; set; }
        public DateTime Tarih { get; set; }
        public string Sofor { get; set; }
        #endregion
        #region Constructor Method
        public SeferIslem(string seferNo, string yer, string kategori, string tarih, string sofor)
        {
            SeferNo = seferNo;
            Yer = yer;
            Kategori = kategori;
            Tarih = Convert.ToDateTime(tarih);
            Sofor = sofor;
        }
        #endregion
        #region File Name
        static string filename = "Seferler.txt";
        #endregion
        #region Methods
        public static void SeferEkle(string yer,string kategori,string tarih,string sofor)
        {
            string seferno = "0";
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            if (lines.Length == 0) seferno = "0";
            else
            {
                for (int i = lines.Length-1; i < lines.Length; i++)
                {
                    string[] split = lines[i].Split(';');
                    seferno = (int.Parse(split[0]) + 1).ToString();
                }
            }
            string line = $"{seferno};{yer};{kategori};{tarih};{sofor}";
            StreamWriter sw = new StreamWriter(path,true);
            sw.WriteLine(line);
            sw.Close();
        }
        public static List<SeferIslem> SeferleriGoruntule()
        {
            List<SeferIslem> seferList = new List<SeferIslem>();
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(';');
                SeferIslem sefer = new SeferIslem(split[0],split[1],split[2],split[3],split[4]);
                seferList.Add(sefer);
            }
            return seferList;
        }
        public static void SeferSil(string seferno) 
        {
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            List<SeferIslem> seferList = new List<SeferIslem>();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(';');
                if (split[0] != seferno)
                {
                    SeferIslem sefer = new SeferIslem(split[0], split[1], split[2], split[3], split[4]);
                    seferList.Add(sefer);
                }
            }
            StreamWriter clear = new StreamWriter(path);
            clear.Write("");
            clear.Close();
            StreamWriter writeNewDatas = new StreamWriter(path,true);
            foreach (var sefer in seferList)
            {
                string line = $"{sefer.SeferNo};{sefer.Yer};{sefer.Kategori};{sefer.Tarih};{sefer.Sofor}";
                writeNewDatas.WriteLine(line);
            }
            writeNewDatas.Close();
        }
        public static List<SeferIslem> SearchWithExpeditionNumber(string seferno)
        {
            List<SeferIslem> seferList = new List<SeferIslem>();
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(';');
                if(split[0] == seferno)
                {
                    SeferIslem sefer = new SeferIslem(split[0], split[1], split[2], split[3], split[4]);
                    seferList.Add(sefer);
                }
            }
            return seferList;
        }
        public static List<SeferIslem> SearchWithDate(string date)
        {
            List<SeferIslem> seferList = new List<SeferIslem>();
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(';');
                if (split[3] == date)
                {
                    SeferIslem sefer = new SeferIslem(split[0], split[1], split[2], split[3], split[4]);
                    seferList.Add(sefer);
                }
            }
            return seferList;
        }
        public static List<SeferIslem> SearchWithPersonalID(string id)
        {
            List<SeferIslem> seferList = new List<SeferIslem>();
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(';');
                if (split[4] == id)
                {
                    SeferIslem sefer = new SeferIslem(split[0], split[1], split[2], split[3], split[4]);
                    seferList.Add(sefer);
                }
            }
            return seferList;
        }
        public static List<SeferIslem> SearchWithLocation(string location)
        {
            List<SeferIslem> seferList = new List<SeferIslem>();
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(';');
                if (split[1] == location)
                {
                    SeferIslem sefer = new SeferIslem(split[0], split[1], split[2], split[3], split[4]);
                    seferList.Add(sefer);
                }
            }
            return seferList;
        }
        public static List<SeferIslem> SearchWithCategory(string category)
        {
            List<SeferIslem> seferList = new List<SeferIslem>();
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(';');
                if (split[2] == category)
                {
                    SeferIslem sefer = new SeferIslem(split[0], split[1], split[2], split[3], split[4]);
                    seferList.Add(sefer);
                }
            }
            return seferList;
        }
        #endregion
    }
}
