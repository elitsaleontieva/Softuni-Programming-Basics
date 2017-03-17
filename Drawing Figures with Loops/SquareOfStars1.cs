using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            for (var i = 1; i <= a; i++)
            {
                Console.Write("*");

                for (var b = 2; b <= a; b++)



                    Console.Write(" *");
                Console.WriteLine();

            }
        }
    }
}
