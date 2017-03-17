using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            for (int i = 1; i <= a; i++)
            {

                Console.WriteLine(new String('*', a));

            }
        }
    }
}
