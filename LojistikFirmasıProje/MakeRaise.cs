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
    public partial class MakeRaise : Form
    {
        public MakeRaise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYuzde.Text == "" || int.Parse(txtYuzde.Text) <= 0)
            {
                MessageBox.Show("Geçersiz işlem!");
                return;
            }
            double yuzde = Convert.ToDouble(txtYuzde.Text);
            Member.MakeRaise(yuzde);
            MessageBox.Show("İşlem başarıyla gerçekleşti.");
            this.Close();
        }
    }
}
