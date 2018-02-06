using DesignPatterns.BusinessServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model
{
    public class Personnel
    {
        public ICalculateSalary m_PersonnelSalary;
        public ICalculatePermit m_PersonnelPermit;

        public Personnel(ICalculateSalary salaryType, ICalculatePermit permit)
        {
            this.m_PersonnelPermit = permit;
            this.m_PersonnelSalary = salaryType;
        }
    }
}
