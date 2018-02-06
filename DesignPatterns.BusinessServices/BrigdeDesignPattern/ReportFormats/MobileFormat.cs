using DesignPatterns.BusinessServices.Interfaces;

namespace DesignPatterns.BusinessServices
{
    public class MobileFormat : IReportFormat
    {
        public string DisplayReportFormat()
        {
            return "Mobile Format";
        }
    }
}
