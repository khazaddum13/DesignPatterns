using DesignPatterns.BusinessServices.ABL;
using System.Collections.Generic;

namespace DesignPatterns.BusinessServices
{
    class Manager : Role
    {
        public override void CreatePermission()
        {
            this.m_Permissions = new List<Permission>()
            {
                new Read(),
                new Write(),
                new Execute(),
                new Delete()
            };
        }
    }
}
