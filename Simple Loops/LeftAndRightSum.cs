using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());


            var c = 0;
            var d = 0;

            for (int i = 0; i < a; i++)


                c = c + int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)

                d = d + int.Parse(Console.ReadLine());



            //Console.WriteLine(c);
            //Console.WriteLine(d);
            if (c == d)
                Console.WriteLine("Yes, sum =" + (c));
            else
            {
                Console.WriteLine("No, diff = " +
        Math.Abs(c - d));
            }

        }
    }
}
