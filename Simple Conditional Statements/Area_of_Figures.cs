using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine().ToLower();

            var a = Double.Parse(Console.ReadLine());



            double area;



            if (x.Equals("square"))
            {
                area = a * a;
                Console.WriteLine(area);
            }

            else if (x.Equals("circle"))
            {
                area = Math.PI * a * a;
                Console.WriteLine(area);

            }



            else if (x.Equals("triangle"))
            {
                var b = Double.Parse(Console.ReadLine());
                area = (a * b) / 2;
                Console.WriteLine(area);
            }

            else if (x.Equals("rectangle"))
            {
                var b3 = Double.Parse(Console.ReadLine());
                area = a * b3;
                Console.WriteLine(area);

            }
        }
    }
}
