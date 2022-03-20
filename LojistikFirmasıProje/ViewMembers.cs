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
    }
}
