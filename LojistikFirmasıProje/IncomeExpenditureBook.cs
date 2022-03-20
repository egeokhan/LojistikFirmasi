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
        }
        private void LoadDatas() => _ieList = IncomeExpenditure.LoadDatas();

        private void Connection() => bs.DataSource = _ieList;

    }
}
