using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorBuilder;

namespace DependencyInjectionDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var builder = new CommissionCalculatorBuilder();
            var calc = builder.buildCommissionCalculator();
            Application.Run(new fmCalculator(calc));
        }
    }
}
