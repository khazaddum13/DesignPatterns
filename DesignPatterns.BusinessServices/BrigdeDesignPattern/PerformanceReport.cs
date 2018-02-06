using DesignPatterns.BusinessServices.Interfaces;

namespace DesignPatterns.BusinessServices
{
    public class PerformanceReport : Rapor
    {
        public PerformanceReport(IReportFormat reportFormat) : base(reportFormat)
        {
        }

        public override string Display()
        {
            return "Performance Report: " + base.Display();
        }
    }
}
