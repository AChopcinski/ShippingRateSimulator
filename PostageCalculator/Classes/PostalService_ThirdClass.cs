using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class PostalService_ThirdClass : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            if (weight < 2)
            {
                double rate = 0.0020 * distance;
                return rate;
            }
            if (weight <8)
            {
                double rate = 0.0022 * distance;
                return rate;
            }
            if (weight <15)
            {
                double rate = 0.0024 * distance;
                return rate;
            }
            if (weight <48)
            {
                double rate = 0.0150 * distance;
                return rate;
            }
            if (weight <128)
            {
                double rate = 0.0160 * distance;
                return rate;
            }
            else
            {
                double rate = 0.0170 * distance;
                return rate;
            }
        }
    }
}
