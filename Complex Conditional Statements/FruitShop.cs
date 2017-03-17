using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var q = double.Parse(Console.ReadLine());
            var price = -1.0;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                //result

                if (fruit == "banana") Console.WriteLine("{0:f2}", price = 2.50 * q);
                if (fruit == "apple") Console.WriteLine("{0:f2}", price = 1.20 * q);
                if (fruit == "orange") Console.WriteLine("{0:f2}", price = 0.85 * q);
                if (fruit == "grapefruit") Console.WriteLine("{0:f2}", price = 1.45 * q);
                if (fruit == "kiwi") Console.WriteLine("{0:f2}", price = 2.70 * q);
                if (fruit == "pineapple") Console.WriteLine("{0:f2}", price = 5.50 * q);

                if (fruit == "grapes") Console.WriteLine("{0:f2}", price = 3.85 * q);
                if ((price / q) < 0) Console.WriteLine("error");


            }
            else if (day == "saturday" || day == "sunday")
            {



                if (fruit == "banana") Console.WriteLine("{0:f2}", price = 2.70 * q);
                if (fruit == "apple") Console.WriteLine("{0:f2}", price = 1.25 * q);
                if (fruit == "orange") Console.WriteLine("{0:f2}", price = 0.90 * q);
                if (fruit == "grapefruit") Console.WriteLine("{0:f2}", price = 1.60 * q);
                if (fruit == "kiwi") Console.WriteLine("{0:f2}", price = 3.00 * q);
                if (fruit == "pineapple") Console.WriteLine("{0:f2}", price = 5.60 * q);

                if (fruit == "grapes") Console.WriteLine("{0:f2}", price = 4.20 * q);

            }

            else
            {
                if ((price / q) < 0) Console.WriteLine("error");
            }

        }
    }
}
