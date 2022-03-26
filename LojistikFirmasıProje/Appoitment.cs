using System;
using System.Collections.Generic;
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
        #region File Name
        static string filename = "Appoitments.txt";
        #endregion
        #region Methods
        public static List<Appoitment> LoadAppointmens()
        {
            List<Appoitment> randevuList = new List<Appoitment>();
            string path = Path.Combine(Application.StartupPath, filename);
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(';');
                Appoitment randevu = new Appoitment(split[0], split[1], split[2], (Onem)int.Parse(split[3]));
                randevuList.Add(randevu);
            }
            return randevuList;

        }
        public static void AddAppointment(string tur, string tarih, string konu, int onem)
        {
            string path = Path.Combine(Application.StartupPath, filename);
            string line = $"{tur};{tarih};{konu};{onem}";
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(line);
            sw.Close();
        }
        #endregion
    }
}
