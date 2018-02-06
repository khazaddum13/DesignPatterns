using DesignPatterns.BusinessServices.Interfaces;

namespace DesignPatterns.BusinessServices.StrategyDesignPattern.Permit
{
    public class CalculateDeptAPermit : ICalculatePermit
    {
        public int CalculatePermit()
        {
            return 21;
        }
    }
}
