using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int glassframelength = n * 2;
            string emptyspaces = new string(' ', n);
            Console.WriteLine("{0}{1}{0}", new string('*', glassframelength), emptyspaces);


            int glasslength = glassframelength - 2;
            for (int rowindex = 0; rowindex < n - 2; rowindex++)
            {
                if (((n % 2 == 0 && rowindex == ((n / 2) - 2))) || ((n % 2 == 1 && rowindex == ((n / 2) - 1))))
                {

                    Console.WriteLine("*{0}*{1}*{0}*",
                                 new string('/', glasslength), new string('|', n));
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*",
                                 new string('/', glasslength), emptyspaces);
                }

            }
            Console.WriteLine("{0}{1}{0}", new string('*', glassframelength), emptyspaces);
        
    }
    }
}
