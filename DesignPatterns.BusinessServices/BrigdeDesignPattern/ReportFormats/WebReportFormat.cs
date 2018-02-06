using DesignPatterns.BusinessServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BusinessServices
{
    public class WebReportFormat : IReportFormat
    {
        public string DisplayReportFormat()
        {
            return "Web Formatı";
        }
    }
}
