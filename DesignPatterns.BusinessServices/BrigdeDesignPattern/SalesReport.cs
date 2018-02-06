using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
