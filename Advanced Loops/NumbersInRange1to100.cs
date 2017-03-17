using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInRange1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Еnter a number in the range [1...100]:");
            var b = int.Parse(Console.ReadLine());
            while (b < 1 || b > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("Еnter a number in the range [1...100]:");
                b = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The number is: " + b);
        
    }
    }
}
