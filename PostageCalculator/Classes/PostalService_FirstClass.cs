using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class PostalService_FirstClass : IDeliveryDriver
    {
        
        public double CalculateRate(int distance, double weight)
        {
            if (weight <2)
            {
                double rate = 0.035 * distance;
                return rate;
            }
            if(weight <8)
            {
                double rate = 0.040 * distance;
                return rate;
            }
            if (weight <15)
            {
                double rate = 0.047 * distance;
                return rate;
            }
            if (weight <48)
            {
                double rate = 0.195 * distance;
                return rate;
            }
            if (weight <128)
            {
                double rate = 0.450 * distance;
                return rate;
            }
            else
            {
                double rate = 0.500 * distance;
                return rate;
            }
            
            
        }
    }
}
