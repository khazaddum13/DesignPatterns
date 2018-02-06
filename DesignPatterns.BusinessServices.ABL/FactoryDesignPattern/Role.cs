using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BusinessServices.ABL
{
    public abstract class Role
    {
        public List<Permission> m_Permissions { get; set; }
        public abstract void CreatePermission();
    }
}
