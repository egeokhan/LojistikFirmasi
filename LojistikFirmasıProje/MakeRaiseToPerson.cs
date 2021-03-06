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
    public partial class MakeRaiseToPerson : Form
    {
        public MakeRaiseToPerson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtYuzde.Text == "" || txtID.Text == "" ||int.Parse(txtYuzde.Text) < 0)
            {
                MessageBox.Show("Geçersiz işlem...");
                return;
            }
            int yuzde = int.Parse(txtYuzde.Text);
            string id = txtID.Text;
            Member.MakeRaiseToPerson(yuzde, id);
            MessageBox.Show($"{id} ID'li kişiye başarıyla zam yapılmıştır.\nZam miktarı: %{yuzde}");
            this.Close();
        }
    }
}
