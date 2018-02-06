using DesignPatterns.BusinessServices.Interfaces;

namespace DesignPatterns.BusinessServices
{
    public class Rapor
    {
        IReportFormat m_ReportFormat;

        public Rapor(IReportFormat reportFormat)
        {
            this.m_ReportFormat = reportFormat;
        }

        public virtual string Display()
        {
            return m_ReportFormat.DisplayReportFormat();
        }
    }
}
