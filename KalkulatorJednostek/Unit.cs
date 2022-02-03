using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class Unit
    {
        public Unit(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public double Ammount { get; set; }
    }
}
