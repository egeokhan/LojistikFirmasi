using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojistikFirmasıProje
{
    public partial class SearchWithPersonalID : Form
    {
        List<SeferIslem> seferList;
        public SearchWithPersonalID()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadExpeditions();
            Connection();
        }
        private void Connection() => bs.DataSource = seferList;
        private void LoadExpeditions() => seferList = SeferIslem.SearchWithPersonalID(textBox1.Text); // textbox1.text = Personal ID
        private void button2_Click(object sender, EventArgs e) => this.Close();
    }
}
