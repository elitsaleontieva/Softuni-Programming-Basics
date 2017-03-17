using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();

            var r = double.Parse(Console.ReadLine());


            var n = double.Parse(Console.ReadLine());
            var a = 0.00;

            if (type == "premiere")
            {
                a = a = 12.00 * r * n;
                Console.WriteLine("{0:f2}", a);
            }

            else if (type == "normal")
            {
                a = 7.50 * r * n;
                Console.WriteLine("{0:f2}", a);
            }

            else if (type == "discount")
            {
                a = 5.00 * r * n;
                Console.WriteLine("{0:f2}", a);
            }
            else
            {
            }

        }
    }
}
