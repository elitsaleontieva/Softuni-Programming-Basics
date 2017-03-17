using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int asterixcount = 1;
            int rows = (2 * n) - 1;

            for (int currrow = 0; currrow < rows; currrow++)

            {
                int emptyspacescount = n - asterixcount;
                Console.Write(new string(' ', emptyspacescount));
                for (int currast = 0; currast < asterixcount; currast++)
                {
                    Console.Write("* ");
                }
                if (currrow < n - 1)
                {
                    asterixcount++;

                }
                else
                {

                    asterixcount--;
                }
                Console.WriteLine();
            }
        }
    }
}
