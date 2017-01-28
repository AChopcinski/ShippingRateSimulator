using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//If two-day business then rate = (weight * 0.050) * distance
//weight 15 oz, distance 340 miles = 15.9375 round up to 15.94

namespace PostageCalculator.Classes
{
    public class SPU_TwoDay : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate;                                // Instantiates a variable to hold the shipping cost
            double ouncesAsPounds = weight / 16.00;     // Converts ounces to pounds, SPU calculates off of pounds.
            rate = (ouncesAsPounds * 0.050) * distance; // Shipping rate calc as determined by SPU for TWO DAY, Line 17 rate variable changes
            return rate;                                // tells what the rate is (set by line 19, referencing line 17)

        }
    }
}
