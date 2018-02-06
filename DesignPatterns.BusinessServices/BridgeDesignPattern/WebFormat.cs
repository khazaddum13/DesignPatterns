using DesignPatterns.BusinessServices.Interfaces;

namespace DesignPatterns.BusinessServices
{
    public class WebFormat : IReportFormat
    {
        public string Generate()
        {
            return "Rapor web formatında oluşturuldu!";
        }
    }
}
