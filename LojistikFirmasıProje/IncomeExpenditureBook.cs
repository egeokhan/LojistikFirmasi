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
    public partial class IncomeExpenditureBook : Form
    {
        List<IncomeExpenditure> _ieList;

        public IncomeExpenditureBook()
        {
            InitializeComponent();
        }

        private void IncomeExpenditureBook_Load(object sender, EventArgs e)
        {
            LoadDatas();
            Connection();
            decimal toplamGelir = 0;
            decimal toplamGider = 0;
            foreach (var ie in _ieList)
            {
                if (ie.GelirGider == GelirGider.Gelir)
                {
                    toplamGelir += ie.Miktar;
                }
                else if (ie.GelirGider == GelirGider.Gider)
                {
                    toplamGider += ie.Miktar;
                }
            }
            lblGider.Text = toplamGider.ToString();
            lblGelir.Text = toplamGelir.ToString();
        }
        private void LoadDatas() => _ieList = IncomeExpenditure.LoadDatas();

        private void Connection() => bs.DataSource = _ieList;

    }
}
