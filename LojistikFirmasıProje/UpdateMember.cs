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
    public partial class UpdateMember : Form
    {
        public UpdateMember()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string ad = txtAdSoyad.Text;
            string departman = txtDepartman.Text;
            string iletisim = txtIletisim.Text;
            string maas = txtMaas.Text;
            Member.UpdateMember(id, ad, departman, iletisim, maas);
            MessageBox.Show("Üye Güncellendi");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            Member member = Member.FindMember(id);
            if (member.AdSoyad == "") 
            { 
                MessageBox.Show("Üye bulunamadı");
                return;
            }
            else
            {
                txtAdSoyad.Text = member.AdSoyad;
                txtDepartman.Text = member.Departman;
                txtIletisim.Text = member.Iletisim;
                txtMaas.Text = member.Maas;
                button1.Enabled = false;
                btnGuncelle.Enabled = true;
                txtID.ReadOnly = true;
            }
        }
    }
}
