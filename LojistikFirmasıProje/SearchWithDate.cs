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
    public partial class SearchWithDate : Form
    {
        List<SeferIslem> seferList;
        public SearchWithDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadExpeditions();
            Connection();
        }
        private void Connection()
        {
            bs.DataSource = seferList;
        }
        private void LoadExpeditions()
        {
            seferList = SeferIslem.SearchWithDate(textBox1.Text); // textbox1.text = Date
        }
    }
}
