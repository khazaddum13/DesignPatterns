using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BusinessServices
{
    public abstract class CommandPerson
    {
        protected PersonBS m_PersonBS;

        public CommandPerson(PersonBS personBS)
        {
            this.m_PersonBS = personBS;
        }

        public abstract void Execute();
    }
}
