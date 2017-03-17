﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());


            var area = 2 * ((Math.Abs(x2 - x1) + Math.Abs(y1 - y2)));
            var perimeter = Math.Abs(x2 - x1) * Math.Abs(y1 - y2);

            Console.WriteLine("{0}", perimeter);
            Console.WriteLine("{0}", area);
        }
    }

    }
