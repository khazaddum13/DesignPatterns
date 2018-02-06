using DesignPatterns.BusinessServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BusinessServices
{
    public class DesktopFormat : IReportFormat
    {
        public string Generate()
        {
            return "Rapor desktop formatında oluşturuldu!";
        }
    }
}
