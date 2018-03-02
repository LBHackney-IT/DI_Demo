namespace DependencyInjectionDemo
{
    class DenmarkCommissionCalculator : ICommissionCalculator
    {
        public double calculateCommission(double amount = 0)
        {
            return (amount * 0.37)/2;
        }
    }
}
