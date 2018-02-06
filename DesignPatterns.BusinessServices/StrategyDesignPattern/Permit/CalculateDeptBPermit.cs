using DesignPatterns.BusinessServices.Interfaces;

namespace DesignPatterns.BusinessServices.StrategyDesignPattern.Permit
{
    public class CalculateDeptBPermit : ICalculatePermit
    {
        public int CalculatePermit()
        {
            return 14;
        }
    }
}
