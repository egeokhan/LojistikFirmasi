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
    public partial class ViewAppointments : Form
    {
        List<Appoitment> randevuList;
        public ViewAppointments()
        {
            InitializeComponent();
        }
        private void Appointments_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            Connection();
        }
        private void Connection() => bs.DataSource = randevuList;
        private void LoadAppointments() => randevuList = Appoitment.LoadAppointmens();
    }
}
