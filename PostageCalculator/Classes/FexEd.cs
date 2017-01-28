using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class FexEd : IDeliveryDriver
    {
        double rate = 20.00;
        public double CalculateRate(int distance, double weight)
        {
            if (weight < 48 && distance < 500)
            {
                return rate;
            }
            if (weight < 48 && distance >= 500)
            {
                rate += 5.00;
                return rate;
            }
            if (weight >=48 && distance <500)
            {
                rate += 3;
                return rate;
            }
            else
            {
                rate += 8;
                return rate;
            }


        }

    }
}
