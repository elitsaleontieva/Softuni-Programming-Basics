using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = Console.ReadLine().ToLower();


            if (x1 == "banana" || x1 == "apple" || x1 == "kiwi" || x1 == "cherry" || x1 == "lemon" || x1 == "grapes")
            {
                Console.WriteLine("fruit");
            }




            else if (x1 == "tomato" || x1 == "cucumber" || x1 == "pepper" || x1 == "carrot")
            {

                Console.WriteLine("vegetable");
            }

            else
            {
                Console.WriteLine("ünknown");
            }
        }
    }
}
