using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//If four-day ground then rate = (weight * 0.0050) * distance
// Weight 15oz, distance 340 miles 1.59375
namespace PostageCalculator.Classes
{
    public class SPU_FourDay : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate;                                //Creates a variable to store the calculated rate
            double ouncesInPounds = weight / 16.00;     //Converts ounces to pounds, SPU calculates shipping weight in pounds
            rate = (ouncesInPounds * 0.0050) * distance; //Formula for 4 days shipping from SPU
            return rate;                                // returns what the shipping cost is
        }
    }
}
