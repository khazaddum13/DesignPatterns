using DesignPatterns.BusinessServices.Interfaces;

namespace DesignPatterns.BusinessServices
{
    public class EmployeePerformanceReport : Rapor
    {
        public EmployeePerformanceReport(IReportFormat reportFormat) : base(reportFormat)
        {
        }

        public override string Display()
        {
            return "Çalışan Performans Raporu: " + base.Display();
        }
    }
}
