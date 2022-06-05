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
    public partial class ChangeServerAdress : Form
    {
        public ChangeServerAdress()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionString.Set(textBox1.Text);
            MessageBox.Show($"Sunucu adı '{textBox1.Text}' olarak değiştirildi");
            this.Close();
        }
    }
}
