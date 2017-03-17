using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian, degrees;
            Console.WriteLine("Enter the degrees : ");
            radian = double.Parse(Console.ReadLine());



            degrees = radian * (180 / Math.PI);
            Console.WriteLine(Math.Round(degrees, 2));

        }
    }
}
