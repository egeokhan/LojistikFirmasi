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
    public partial class ViewExpeditions : Form
    {
        List<SeferIslem> seferler;
        public ViewExpeditions()
        {
            InitializeComponent();
        }

        private void ViewExpeditions_Load(object sender, EventArgs e)
        {
            LoadExpeditions();
            Connect();

        }

        private void LoadExpeditions()
        {
            seferler = SeferIslem.SeferleriGoruntule();
        }

        private void Connect()
        {
            bs.DataSource = seferler;
        }
    }
}
