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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Giris();
            this.IsMdiContainer = true;
            timer1.Enabled = true;
        }

        private void Giris()
        {
            this.Visible = false;
            LoginScreen lgsc = new LoginScreen();
            lgsc.ShowDialog();
            if (lgsc.DialogResult == DialogResult.OK) this.Visible = true;
            else if (lgsc.DialogResult == DialogResult.Cancel) Close();
        }

        private void timer1_Tick(object sender, EventArgs e) => lblTarih.Text = DateTime.Now.ToString("d/M/yyyy");
        private void haklarVeLisansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Okhan Lojistik 2022. Tüm hakları saklıdır.");
        }

        private void seferEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExpedition addexpedition = new AddExpedition();
            addexpedition.MdiParent = this;
            addexpedition.Show();
        }

        private void seferleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewExpeditions viewexpeditions = new ViewExpeditions();
            viewexpeditions.MdiParent = this;
            viewexpeditions.Show();
        }

        private void seferNoyaGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWithExpeditionNO swen = new SearchWithExpeditionNO();
            swen.MdiParent = this;
            swen.Show();
        }

        private void personelIDsineGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWithPersonalID swpi = new SearchWithPersonalID();
            swpi.MdiParent = this;
            swpi.Show();
        }

        private void tariheGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWithDate swd = new SearchWithDate();
            swd.MdiParent = this;
            swd.Show();
        }

        private void seferYerineGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWithLocation swl = new SearchWithLocation();
            swl.MdiParent = this;
            swl.Show();
        }

        private void kategoriyeGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWithCategory swc = new SearchWithCategory();
            swc.MdiParent = this;
            swc.Show();
        }

        private void üyeleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMembers vm = new ViewMembers();
            vm.MdiParent = this;
            vm.Show();
        }

        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember addmember = new AddMember();
            addmember.MdiParent = this;
            addmember.Show();
        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.MdiParent = this;
            dm.Show();
        }
        private void üyeAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();
            sm.MdiParent = this;
            sm.Show();
        }
        private void button1_Click(object sender, EventArgs e) => this.Close();

        private void yaklaşanGörüşmelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAppointments va = new ViewAppointments();
            va.MdiParent = this;
            va.Show();
        }

        private void randevuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAppointment aa = new AddAppointment();
            aa.MdiParent = this;
            aa.Show();
        }

        private void kullanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.MdiParent = this;
            info.Show();
        }

        private void firmaGelirGiderleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomeExpenditureBook ieb = new IncomeExpenditureBook();
            ieb.MdiParent = this;
            ieb.Show();
        }

        private void kişiyeGöreDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryDeductionToPerson sdtp = new SalaryDeductionToPerson();
            sdtp.MdiParent = this;
            sdtp.Show();
        }

        private void herkesinkiniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryDeduction sd = new SalaryDeduction();
            sd.MdiParent = this;
            sd.Show();
        }

        private void maaşlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomeExpenditure.GiveSalary();
            MessageBox.Show("Maaşlar verildi!");
        }

        private void gelirEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirEkle frm = new FrmGelirEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderEkle frm = new FrmGiderEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sunucuAdıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeServerAdress csa = new ChangeServerAdress();
            csa.MdiParent = this;
            csa.Show();
        }
    }
}
