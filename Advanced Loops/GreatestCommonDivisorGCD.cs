using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisorGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            while (b != 0)
            {
                var c = b;
                b = a % b;
                a = c;
            }
            Console.WriteLine("GCD = {0}", a);

        }
    }
}
