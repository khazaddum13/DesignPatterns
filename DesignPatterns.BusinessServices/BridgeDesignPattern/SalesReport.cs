using DesignPatterns.BusinessServices.Interfaces;

namespace DesignPatterns.BusinessServices
{
    public class SalesReport : Rapor
    {
        public SalesReport(IReportFormat reportFormat) : base(reportFormat)
        {
        }

        public override string Display()
        {
            return "Satış Raporu: " + base.Display();
        }
    }
}
