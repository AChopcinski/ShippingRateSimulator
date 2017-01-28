using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class SPU_NextDay : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate;                                    // instantiates a variable named rate to store data
            double ouncesAsPounds = weight / 16.00;         // SPU calculates off of pounds, this converts our ounce caluclation to pounds
            rate = (ouncesAsPounds * 0.075) * distance;     // formula for next day delivery
            return rate;                                    // rate will be what item will cost to ship next day
        }
    }
}
