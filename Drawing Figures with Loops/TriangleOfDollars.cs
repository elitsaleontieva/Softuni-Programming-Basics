﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var r = 1; r <= n; r++)
            {
                Console.Write("$");
                for (var c = 1; c < r; c++)//c <r!!! 
                    Console.Write(" $");
                Console.WriteLine();
            }

        }
    }
}
