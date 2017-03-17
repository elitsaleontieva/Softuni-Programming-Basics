using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOfNxNStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());


            for (int i = 1; i <= a; i++)
            {

                Console.WriteLine(new String('*', a));

            }
        }
    }
}
