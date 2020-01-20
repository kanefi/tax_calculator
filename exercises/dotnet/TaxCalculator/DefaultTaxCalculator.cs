using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class DefaultTaxCalculator : TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            if (vehicle.Co2Emissions == 0)
            {
                return 0;
            }

            else if (vehicle.Co2Emissions <= 50)
            {
                return 10;
            }
            else if (vehicle.Co2Emissions <= 75)
            {
                return 25;
            }
            else if (vehicle.Co2Emissions <= 89)
            {
                return 105;
            }
            else if (vehicle.Co2Emissions <= 99)
            {
                return 105;
            }
            else if (vehicle.Co2Emissions <= 109)
            {
                return 125;
            }
            else if (vehicle.Co2Emissions <= 129)
            {
                return 145;
            }
            else if (vehicle.Co2Emissions <= 149)
            {
                return 165;
            }
            else if (vehicle.Co2Emissions <= 169)
            {
                return 205;
            }
            else if (vehicle.Co2Emissions <= 189)
            {
                return 515;
            }
            else if (vehicle.Co2Emissions <= 224)
            {
                return 830;
            }
            else if (vehicle.Co2Emissions <= 254)
            {
                return 1240;
            }
            else if (vehicle.Co2Emissions <= 255)
            {
                return 1760;
                }
            else return 2070;
        }
    }
}
