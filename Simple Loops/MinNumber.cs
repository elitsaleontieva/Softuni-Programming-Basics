using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine()); //kolko da sa
            var max = int.MaxValue;

            for (int d = 0; d < a; d++)
            {


                var c = int.Parse(Console.ReadLine()); //b inputs 
                if (c < max)
                    max = c;

            }
            Console.WriteLine(max);
        }
    }
}
