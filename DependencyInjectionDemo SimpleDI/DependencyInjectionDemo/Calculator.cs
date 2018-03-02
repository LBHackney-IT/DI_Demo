namespace DependencyInjectionDemo
{
    class CommissionCalculator : ICommissionCalculator
    {
        public double calculateCommission(double amount = 0)
        {
            return amount * 0.1;
        }
    }
}
