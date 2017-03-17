using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool prime = true;
            for (int i = 2; i < n && n >= 2; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime && n >= 2)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
