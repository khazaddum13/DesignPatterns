using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model
{
    public class Person : ICloneable
    {
        public int m_PersonId { get; set; }
        public string m_PersonName { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
