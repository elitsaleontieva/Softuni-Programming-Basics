using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string spaces = new string(' ', n - 2);
            string startingStars = new string('*', n);

            Console.WriteLine(startingStars);

            for (int i = 1; i <= (n - 2); i++)
            {
                Console.WriteLine("*" + spaces + "*");
            }
            Console.WriteLine(startingStars);
        }
    }
}
