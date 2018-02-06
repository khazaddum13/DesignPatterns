using DesignPatterns.BusinessServices.Interfaces;

namespace DesignPatterns.BusinessServices
{
    public class DesktopFormat : IReportFormat
    {
        public string DisplayReportFormat()
        {
            return "Desktop Format";
        }
    }
}
