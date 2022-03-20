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
    public partial class SalaryDeduction : Form
    {
        public SalaryDeduction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYuzde.Text == "" || int.Parse(txtYuzde.Text) < 0)
            {
                MessageBox.Show("Geçersiz işlem...");
                return;
            }
            int yuzde = int.Parse(txtYuzde.Text);
            Member.SalaryDeduction(yuzde);
            MessageBox.Show($"Maaş düşürülme miktarı: %{yuzde}");
            this.Close();
        }
    }
}
