using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DependencyInjectionDemo
{
    class CommissionCalculatorBuilder
    {
        private string _locale;
        public CommissionCalculatorBuilder()
        {
            _locale = ConfigurationSettings.AppSettings["Locale"];
        }

        public ICommissionCalculator buildCommissionCalculator()
        {
            switch (_locale)
            {
                case "UK":
                {
                    return new UkCommissionCalculator();
                }
                case "Denmark":
                {
                    return new DenmarkCommissionCalculator();
                }
                default:
                {
                    return new CommissionCalculator();
                }
            }
        }
    }
}
