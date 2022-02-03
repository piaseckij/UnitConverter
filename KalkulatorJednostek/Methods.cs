using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class Methods
    {
        public static IEnumerable<Unit> AddUnits()
        {
            List<Unit> units= new List<Unit>();
                
            units.Add(new Unit("Meters"));
            units.Add(new Unit("Feet"));
            units.Add(new Unit("Miles"));
            units.Add(new Unit("Kilometer"));

            return units;
        }

        public static void Calculate(Unit from, Unit to)
        {
            double inMeters = 0;

            switch (from.Name)
            {
                case "Meters":
                    inMeters = from.Ammount;
                    break;
                case "Feet":
                    inMeters = from.Ammount * 0.3048;
                    break;
                case "Miles":
                    inMeters=from.Ammount * 1609.344;
                    break;
                case "Kilometer":
                    inMeters = from.Ammount * 1000;
                    break;
            }

            switch (to.Name)
            {
                case "Meters":
                    to.Ammount = inMeters;
                    break;
                case "Feet":
                    to.Ammount = inMeters * 3.2808399;
                    break;
                case "Miles":
                    to.Ammount = inMeters * 0.000621371192;
                    break;
                case "Kilometer":
                    to.Ammount = inMeters / 1000;
                    break;
            }

        }
    }
}
