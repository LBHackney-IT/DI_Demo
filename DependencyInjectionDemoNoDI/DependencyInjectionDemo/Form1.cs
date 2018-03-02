using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyInjectionDemo
{
    public partial class fmCalculator : Form
    {
        private CommissionCalculator _myCalculator;
        public fmCalculator()
        {
            InitializeComponent();
        }

        private void calculateCommission_Click(object sender, EventArgs e)
        {
            _myCalculator = new CommissionCalculator();
            int sales = 0;
            if (Int32.TryParse(txtSalesAmount.Text, out sales))
            {
                txtCommission.ForeColor = Color.Black;
                txtCommission.Text = _myCalculator.calculateCommission(sales).ToString();
            }
            else
            {
                txtCommission.ForeColor = Color.Red;
                txtCommission.Text = "Invalid input.";
            }
        }
    }
}
