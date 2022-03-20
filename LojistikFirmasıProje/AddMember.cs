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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adsoyad = txtAdSoyad.Text;
            string departman = txtDepartman.Text;
            string iletisim = txtIletisim.Text;
            string maas = txtMaas.Text;
            Member.AddMember(adsoyad,departman,iletisim,maas);
            MessageBox.Show("Üye Eklendi!");
            this.Close();
        }
    }
}
