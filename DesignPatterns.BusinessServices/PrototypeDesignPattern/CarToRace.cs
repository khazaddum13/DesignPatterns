using DesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BusinessServices
{
    public class CarToRace : List<Car>
    {
        public List<Car> Race()
        {
            List<Car> result = new List<Car>();
            foreach (var item in this)
            {
                result.Add(item);
            }
            return result;
        }
    }
}
