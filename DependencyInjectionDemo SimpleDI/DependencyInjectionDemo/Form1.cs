using System;
using System.Drawing;
using System.Windows.Forms;

namespace DependencyInjectionDemo
{
    public partial class fmCalculator : Form
    {
        private ICommissionCalculator _myCalculator;
        public fmCalculator(ICommissionCalculator calculator)
        {
            _myCalculator = calculator;
            InitializeComponent();
        }

        private void calculateCommission_Click(object sender, EventArgs e)
        {
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
