using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, faren;
            Console.WriteLine("Enter the Temperature in Celsius(°C) : ");
            celsius = double.Parse(Console.ReadLine());

            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine(Math.Round(faren, 2));
        }
    }
}
