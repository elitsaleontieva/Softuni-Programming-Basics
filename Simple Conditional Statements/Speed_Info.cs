using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine()); //x=speed

            if (x <= 10)
            {
                Console.WriteLine("slow");
            }


            else if (x >= 10.01 && x <= 50.00)
            {
                Console.WriteLine("average"); //1

            }
            else if (x >= 50.01 && x <= 150)
            {
                Console.WriteLine("fast"); //2

            }

            else if (x >= 150.01 && x <= 1000) //3
            {
                Console.WriteLine("ultra fast");

            }

            else if (x > 1000.01) //4
            {
                Console.WriteLine("extremely fast");

            }

        }
    }
}
