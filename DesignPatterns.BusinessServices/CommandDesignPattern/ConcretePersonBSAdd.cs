using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BusinessServices
{
    public class ConcretePersonBSAdd : CommandPerson
    {
        public ConcretePersonBSAdd(PersonBS personBS) : base(personBS)
        {
        }

        public override void Execute()
        {
            this.m_PersonBS.AddPerson()
        }
    }
}
