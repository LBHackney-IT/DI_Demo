using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    class CommissionCalculator
    {
        internal double calculateCommission(double amount = 0)
        {
            return amount * 0.1;
        }
    }
}
