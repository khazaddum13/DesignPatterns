using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BusinessServices.ABL
{
    public abstract class Permission
    {
        public override string ToString()
        {
            return base.GetType().Name;
        }
    }
}
