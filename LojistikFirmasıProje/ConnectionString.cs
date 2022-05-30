using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojistikFirmasıProje
{
    public class ConnectionString
    {
        public string ServerName { get; set; }
        static string path = Path.Combine(Application.StartupPath, "ConnectionString.txt");
        public static string Get()
        {
            string connectionString = File.ReadAllText(path);
            return connectionString;
        }
        public static void Set(string serverName)
        {
            StreamWriter sw = new StreamWriter(path);
            string connectionString = $"Server={serverName};Database=Lojistik;Trusted_Connection=True;";
            sw.Write(connectionString);
            sw.Close();
        }
    }
}
