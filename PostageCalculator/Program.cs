using PostageCalculator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeliveryDriver> priceList = new List<IDeliveryDriver>();

            priceList.Add(new PostalService_FirstClass());
            priceList.Add(new PostalService_SecondClass());
            priceList.Add(new PostalService_ThirdClass());
            priceList.Add(new FexEd());
            priceList.Add(new SPU_NextDay());
            priceList.Add(new SPU_TwoDay());
            priceList.Add(new SPU_FourDay());

            while (true)
            {
                double weight;

                Console.WriteLine();
                Console.WriteLine("Welcome to the only Postage Calculator you'll ever need!");
                Console.WriteLine("You enter in your package weight and how many miles it's going, and we do the rest!");
                Console.WriteLine("Note: All rates are accurate as of 01/27/2017.");
                Console.WriteLine();
                Console.WriteLine("Please enter your package weight:");
                double unitsOfWeight = double.Parse(Console.ReadLine());
                Console.WriteLine($"Was {unitsOfWeight} (P)ounds or (O)unces? Please enter P or O");
                string ozOrLb = Console.ReadLine().ToUpper();
                while (ozOrLb != "P" && ozOrLb!= "O")
                {
                   Console.WriteLine($"P or O...not that difficult. Try again cheif.");
                   ozOrLb = Console.ReadLine().ToUpper();
                }
                if (ozOrLb == "P")
                {
                    weight = unitsOfWeight * 16;
                }
                else
                {
                    weight = unitsOfWeight;
                }
                Console.WriteLine($"Great! Now enter the number of miles it is going.");
                int distance = int.Parse(Console.ReadLine());

                Console.WriteLine($"Behold...your shipping options.");
                Console.WriteLine();
                Console.WriteLine("Shipping Option".PadRight(30) + "Cost");
                Console.WriteLine($"-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
                Console.WriteLine("Postal First Class".PadRight(30) + Math.Round((priceList[0].CalculateRate(distance, weight)), 2).ToString("C"));
                Console.WriteLine("Second First Class".PadRight(30) + Math.Round((priceList[1].CalculateRate(distance, weight)), 2).ToString("C"));
                Console.WriteLine("Third First Class".PadRight(30) + Math.Round((priceList[2].CalculateRate(distance, weight)), 2).ToString("C"));
                Console.WriteLine("FexEd".PadRight(30) + Math.Round((priceList[3].CalculateRate(distance, weight)), 2).ToString("C"));
                Console.WriteLine("SPU Next Day".PadRight(30) + Math.Round((priceList[4].CalculateRate(distance, weight)), 2).ToString("C"));
                Console.WriteLine("SPU Two Day".PadRight(30) + Math.Round((priceList[5].CalculateRate(distance, weight)), 2).ToString("C"));
                Console.WriteLine("SPU Four Day".PadRight(30) + Math.Round((priceList[6].CalculateRate(distance, weight)), 2).ToString("C"));

                //if (ozOrLb =="P" || ozOrLb =="p")
                //{
                //    weight = unitsOfWeight * 16;
                //}
                //else if (ozOrLb == "O" || ozOrLb == "o" )
                //{
                //    weight = unitsOfWeight;
                //}
                //else
                //{

                //}


                Console.ReadLine();




            }
        }
    }
}
