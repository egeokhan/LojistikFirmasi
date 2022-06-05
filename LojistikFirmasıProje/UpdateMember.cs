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
        Member _member;
        public UpdateMember(Member member)
        {
            InitializeComponent();
            _member = member;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string id = _member.ID;
            string ad = txtAdSoyad.Text;
            string departman = txtDepartman.Text;
            string iletisim = txtIletisim.Text;
            string maas = txtMaas.Text;
            Member.UpdateMember(id, ad, departman, iletisim, maas);
            MessageBox.Show("Üye Güncellendi");
            this.Close();
        }

        private void UpdateMember_Load(object sender, EventArgs e)
        {
            txtAdSoyad.Text = _member.AdSoyad;
            txtDepartman.Text = _member.Departman;
            txtIletisim.Text = _member.Iletisim;
            txtMaas.Text = _member.Maas;
        }
    }
}
