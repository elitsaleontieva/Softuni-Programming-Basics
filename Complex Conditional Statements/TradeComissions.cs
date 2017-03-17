using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var s = double.Parse(Console.ReadLine()); //sales


            //result
            double c = -1;

            if (s < 0)
            {
                Console.WriteLine("error");

            }
            else if (town == "sofia")
            {
                //result

                if (s >= 0 && s <= 500) Console.WriteLine("{0:f2}", c = s * 0.05);

                if (s > 500 && s <= 1000) Console.WriteLine("{0:f2}", c = s * 0.07);

                if (s > 1000 && s <= 10000) Console.WriteLine("{0:f2}", c = s * 0.08);
                if (s > 10000) Console.WriteLine("{0:f2}", c = s * 0.12);

            }



            else if (town == "varna")
            {
                //result

                if (s >= 0 && s <= 500) Console.WriteLine("{0:f2}", c = s * 0.045);

                if (s > 500 && s <= 1000) Console.WriteLine("{0:f2}", c = s * 0.075);

                if (s > 1000 && s <= 10000) Console.WriteLine("{0:f2}", c = s * 0.10);
                if (s > 10000) Console.WriteLine("{0:f2}", c = s * 0.13);



            }

            else if (town == "plovdiv")
            {
                //result

                if (s >= 0 && s <= 500) Console.WriteLine("{0:f2}", c = s * 0.055);

                if (s > 500 && s <= 1000) Console.WriteLine("{0:f2}", c = s * 0.08);

                if (s > 1000 && s <= 10000) Console.WriteLine("{0:f2}", c = s * 0.12);
                if (s > 10000) Console.WriteLine("{0:f2}", c = s * 0.145);
            }





            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
