using DesignPatterns.BusinessServices.Interfaces;

namespace DesignPatterns.BusinessServices.StrategyDesignPattern.Salary
{
    public class CalculateManagerSalary : ICalculateSalary
    {
        public int CalculateSalary()
        {
            return 1000;
        }
    }
}
