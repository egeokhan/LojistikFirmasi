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
    public partial class FrmGelirEkle : Form
    {
        public FrmGelirEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            IncomeExpenditure.GelirEkle(txtTur.Text, txtTarih.Value, int.Parse(txtMiktar.Text));
            MessageBox.Show("Eklendi!");
            this.Close();
        }
    }
}
