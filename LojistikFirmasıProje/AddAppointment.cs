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
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
        }
        private void AddAppointment_Load(object sender, EventArgs e) => cmbOnem.SelectedIndex = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Appoitment.AddAppointment(txtTur.Text,dateTimePicker1.Text, txtKonu.Text, cmbOnem.SelectedIndex);
            MessageBox.Show("Görüşme başarıyla eklendi.");
            this.Close();
        }
    }
}
