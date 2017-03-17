using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Invalid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());


            var x2 = (x1 >= 100 && x1 <= 200 || x1 == 0);

            if (!x2) { Console.WriteLine("invalid"); }


        }
    }
    }
}
