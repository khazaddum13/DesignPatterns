using DesignPatterns.BusinessServices.Interfaces;

namespace DesignPatterns.BusinessServices.StrategyDesignPattern.Salary
{
    public class CalculateTechnicianSalary : ICalculateSalary
    {
        public int CalculateSalary()
        {
            return 3000;
        }
    }
}
