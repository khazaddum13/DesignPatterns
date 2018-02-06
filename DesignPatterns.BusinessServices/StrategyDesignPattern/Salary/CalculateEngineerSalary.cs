using DesignPatterns.BusinessServices.Interfaces;

namespace DesignPatterns.BusinessServices.StrategyDesignPattern.Salary
{
    public class CalculateEngineerSalary : ICalculateSalary
    {
        public int CalculateSalary()
        {
            return 5000;
        }
    }
}
