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
    public partial class SearchWithExpeditionNO : Form
    {
        List<SeferIslem> sefer;
        public SearchWithExpeditionNO()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadExpeditions();
            Connection();
        }
        private void Connection() => bs.DataSource = sefer;
        private void LoadExpeditions() => sefer = SeferIslem.SearchWithExpeditionNumber(textBox1.Text); // textbox1.text = expedition number
        private void button2_Click(object sender, EventArgs e) => this.Close();
    }
}