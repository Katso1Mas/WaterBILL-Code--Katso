using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Katso
{
    internal class DOMESTICCalculation
    {
        public double PotablePriceOfWater(double AmountOfWater)
        {

            double PriceOfWater;
            double VATexclude = 3.60 * 5;


            if (AmountOfWater <= 5)
            {

                PriceOfWater = (3.60 * AmountOfWater);
                return PriceOfWater;
            }
            else if (AmountOfWater > 5 && AmountOfWater <= 15)
            {


                PriceOfWater = ((AmountOfWater - 5) * (13.43)) + (VATexclude);
                return PriceOfWater;
            }
            else if (AmountOfWater > 15 && AmountOfWater <= 25)
            {

                PriceOfWater = ((AmountOfWater - 15) * (23.51)) + (10 * 13.43) + (VATexclude);
                return PriceOfWater;

            }
            else if (AmountOfWater > 25 && AmountOfWater <= 40)
            {

                PriceOfWater = ((AmountOfWater - 25) * (36.16)) + (10 * 13.43) + (10 * 23.51) + (VATexclude);
                return PriceOfWater;
            }
            else
            {

                PriceOfWater = ((AmountOfWater - 40) * (45.21)) + (10 * 13.43) + (10 * 23.51) + (15 * 36.16) + (VATexclude);
                return PriceOfWater;
            }

        }

        public double WastePriceOfWater(double AmountOfWater)
        {

            double PriceOfWater;
            double VATexclude = 0.65 * 5;





            if (AmountOfWater <= 5)
            {

                PriceOfWater = (0.65 * AmountOfWater);
                return PriceOfWater;
            }
            else if (AmountOfWater > 5 && AmountOfWater <= 15)
            {


                PriceOfWater = ((AmountOfWater - 5) * (3.36)) + (VATexclude);
                return PriceOfWater;
            }
            else if (AmountOfWater > 15 && AmountOfWater <= 25)
            {

                PriceOfWater = ((AmountOfWater - 15) * (5.03)) + (10 * 3.36) + (VATexclude);
                return PriceOfWater;

            }
            else if (AmountOfWater > 25 && AmountOfWater <= 40)
            {

                PriceOfWater = ((AmountOfWater - 25) * (6.71)) + (10 * 3.36) + (10 * 5.03) + (VATexclude);
                return PriceOfWater;
            }
            else
            {

                PriceOfWater = ((AmountOfWater - 40) * (8.39)) + (10 *3.36 ) + (10 * 5.03) + (15 * 6.71) + (VATexclude);
                return PriceOfWater;
            }
        }
        public double DOMESTICTotalPriceOfWater(double AmountOfWater)
        {
            DOMESTICCalculation calculation = new DOMESTICCalculation();    
            return calculation.PotablePriceOfWater(AmountOfWater) + calculation.WastePriceOfWater(AmountOfWater);
            
        }
}
}


