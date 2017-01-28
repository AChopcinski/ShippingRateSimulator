using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class PostalService_SecondClass : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            if (weight < 2)
            {
                double rate = 0.0035 * distance;
                return rate;
            }
            if (weight < 8)
            {
                double rate = 0.0040 * distance;
                return rate;
            }
            if (weight < 15)
            {
                double rate = 0.0047 * distance;
                return rate;
            }
            if (weight <48)
            {
                double rate = 0.0195 * distance;
                return rate;
            }
            if (weight <128)
            {
                double rate = 0.0450 * distance;
                return rate;
            }
            else
            {
                double rate = 0.0500 * distance;
                return rate;
            }
        }
    }
}
