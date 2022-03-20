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
    public partial class DeleteExpedition : Form
    {
        public DeleteExpedition()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string seferno = txtSeferNo.Text;
            SeferIslem.SeferSil(seferno);
            MessageBox.Show("Sefer Silindi.");
            this.Close();
        }
    }
}
