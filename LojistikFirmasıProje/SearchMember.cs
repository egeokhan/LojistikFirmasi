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
    public partial class SearchMember : Form
    {
        Member aranan;
        public SearchMember()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FindMember();
            Connect();
        }
        private void Connect() => bs.DataSource = aranan;
        private void FindMember() => aranan = Member.FindMember(textBox1.Text); // id = textbox1.text
        private void button2_Click(object sender, EventArgs e) => this.Close();
    }
}
