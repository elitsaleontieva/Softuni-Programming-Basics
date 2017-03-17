using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, USD;
            Console.WriteLine("Enter value in USD:  ");
            USD = double.Parse(Console.ReadLine());

            a = 1.79549;

            double BGN = a * USD;

            Console.WriteLine("{0:0.00}", BGN); Console.Write("BGN");
        }
    }
}
