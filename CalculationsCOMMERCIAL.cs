using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Katso
{
    internal class COMMERCIALCalculation
    {
        public double PotablePriceOfWater(double AmountOfWater)
        {

            double PriceOfWater;
            

            if (AmountOfWater <= 5)
            {

                PriceOfWater = (4.92 * AmountOfWater);
                return PriceOfWater;
            }
            else if (AmountOfWater > 5 && AmountOfWater <= 15)
            {


                PriceOfWater = ((AmountOfWater - 5)*(14.61))+(5*4.92);
                return PriceOfWater;
            }
            else if (AmountOfWater > 15 && AmountOfWater <= 25)
            {

                PriceOfWater = ((AmountOfWater - 15) * (25.58)) + (10 * 14.61)+(5*4.92);
                return PriceOfWater;

            }
            else if (AmountOfWater > 25 && AmountOfWater <= 40)
            {

                PriceOfWater = ((AmountOfWater - 25) * (39.35)) + (5*4.92) + (10 * 14.61)+(10* 25.58);
                return PriceOfWater;
            }
            else
            {

                PriceOfWater = ((AmountOfWater - 40) * (49.20)) +(5*4.92)+ (10 *14.61 ) + (10 * 25.58) + (15 * 39.35);
                return PriceOfWater;
            }

        }
        public double WastePriceOfWater(double AmountOfWater)
        {

            double PriceOfWater;
            





            if (AmountOfWater <= 5)
            {

                PriceOfWater = (0.65 * AmountOfWater);
                return PriceOfWater;
            }
            else if (AmountOfWater > 5 && AmountOfWater <= 15)
            {


                PriceOfWater = ((AmountOfWater - 5) * (3.36)) + (5*0.74) ;
                return PriceOfWater;
            }
            else if (AmountOfWater > 15 && AmountOfWater <= 25)
            {

                PriceOfWater = ((AmountOfWater - 15) * (5.03)) + (10 * 3.36) + (5 * 0.74);
                return PriceOfWater;

            }
            else if (AmountOfWater > 25 && AmountOfWater <= 40)
            {

                PriceOfWater = ((AmountOfWater - 25) * (6.71)) + (10 * 3.36) + (10 * 5.03) + (5*0.74);
                return PriceOfWater;
            }
            else
            {

                PriceOfWater = ((AmountOfWater - 40) * (8.39)) + (10 * 3.36) + (10 * 5.03) + (15 * 6.71) + (5*0.74);
                return PriceOfWater;
            }
        }
        public double COMMERCIALTotalPriceOfWater(double AmountOfWater)
        {
            COMMERCIALCalculation calculation = new COMMERCIALCalculation();
            return calculation.PotablePriceOfWater(AmountOfWater) + calculation.WastePriceOfWater(AmountOfWater);

        }
    }
}







    

