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
    public partial class AddExpedition : Form
    {
        public AddExpedition()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string yer = txtYer.Text;
            string kategori = txtKategori.Text;
            string tarih = dateTimePicker1.Text;
            string sofor = txtSofor.Text;
            SeferIslem.SeferEkle(yer, kategori, tarih, sofor);
            MessageBox.Show("Sefer Eklendi!");
            this.Close();
        }
    }
}
