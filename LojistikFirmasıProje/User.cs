using System;
using System.Collections.Generic;
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
        string username,password;
        #endregion
        #region Constructer Method
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        #endregion
        #region Methods
        public bool GirisKontrol()
        {
            string path = Path.Combine(Application.StartupPath, "Users.txt");
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(';');
                if (split[0] == username && split[1] == password) return true;
            }
            return false;
        }
        #endregion
    }
}
