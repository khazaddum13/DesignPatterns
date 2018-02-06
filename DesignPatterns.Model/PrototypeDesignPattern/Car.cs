using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Model
{
    public class Car : ICloneable
    {
        public string m_Name { get; set; }
        public int m_Velocity { get; set; }
        public int m_Acceleration { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
