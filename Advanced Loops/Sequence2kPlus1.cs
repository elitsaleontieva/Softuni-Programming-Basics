﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            var n = int.Parse(Console.ReadLine());
            while (a <= n)
            {


                Console.WriteLine(a);
                a = ((a * 2) + 1);
            }
        }
    }
}
