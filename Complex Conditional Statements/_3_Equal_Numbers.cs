using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pass = Double.Parse(Console.ReadLine());
            var pass2 = Double.Parse(Console.ReadLine());
            var pass3 = Double.Parse(Console.ReadLine());



            if (pass == pass2 && pass2 == pass3)
            {
                Console.WriteLine("yes");
                return;
            }
            else
            {
                Console.WriteLine("no");

            }
        }
    }
}
