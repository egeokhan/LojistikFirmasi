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
    public partial class ViewMembers : Form
    {
        List<Member> memberList;
        public ViewMembers()
        {
            InitializeComponent();
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            LoadMembers();
            Connection();
        }

        private void Connection()
        {
            bs.DataSource = memberList;
        }

        private void LoadMembers()
        {
            memberList = Member.LoadMembers();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member seciliUye = (Member)bs.Current;
            DialogResult dr =MessageBox.Show("Silmek istediğinize emin misiniz?","Onay",MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;
            Member.DeleteMember(seciliUye.ID);
            bs.DataSource = Member.LoadMembers();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMember frm = new UpdateMember((Member)bs.Current);
            frm.ShowDialog();
            bs.DataSource = Member.LoadMembers();
        }
    }
}
