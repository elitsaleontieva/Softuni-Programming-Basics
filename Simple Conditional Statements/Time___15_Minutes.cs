using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            int totalminutes = ((hours * 60) + min + 15);
            int a = totalminutes / 60; //chasove


            if (a >= 24)
            {
                a -= 24; //x -= y is the same as x = x - y 

            }

            var b = totalminutes % 60;

            Console.WriteLine("{0}:{1:00}", a, b);
        }
    }
    }
