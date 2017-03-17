using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal size = decimal.Parse(Console.ReadLine());
            string sourceMetric = Console.ReadLine().ToLower();
            string destMetric = Console.ReadLine().ToLower();
            decimal sizeMetres = 0.0M;
            if (sourceMetric == "km")
            {
                sizeMetres = size / 0.001M;
            }
            else if (sourceMetric == "ft")
            {
                sizeMetres = size / 3.2808399M;
            }
            else if (sourceMetric == "yd")
            {
                sizeMetres = size / 1.0936133M;
            }
            else if (sourceMetric == "in")
            {
                sizeMetres = size / 39.3700787M;
            }
            else if (sourceMetric == "mi")
            {
                sizeMetres = size / 0.000621371192M;
            }
            else if (sourceMetric == "cm")
            {
                sizeMetres = size / 100M;
            }
            else if (sourceMetric == "mm")
            {
                sizeMetres = size / 1000M;
            }
            else if (sourceMetric == "m")
            {
                sizeMetres = size;
            }
            decimal outputsizeMetres = 0.0M;
            if (destMetric == "m")
            {
                Console.WriteLine("{0} {1}", sizeMetres, destMetric);
            }
            else if (destMetric == "km")
            {
                outputsizeMetres = sizeMetres * 0.001M;
                Console.WriteLine("{0} {1}", outputsizeMetres, destMetric);
            }
            else if (destMetric == "ft")
            {
                outputsizeMetres = sizeMetres * 3.2808399M;
                Console.WriteLine("{0} {1}", outputsizeMetres, destMetric);
            }
            else if (destMetric == "yd")
            {
                outputsizeMetres = sizeMetres * 1.0936133M;
                Console.WriteLine("{0} {1}", outputsizeMetres, destMetric);
            }
            else if (destMetric == "in")
            {
                outputsizeMetres = sizeMetres * 39.3700787M;
                Console.WriteLine("{0} {1}", outputsizeMetres, destMetric);
            }
            else if (destMetric == "mi")
            {
                outputsizeMetres = sizeMetres * 0.000621371192M;
                Console.WriteLine("{0} {1}", outputsizeMetres, destMetric);
            }
            else if (destMetric == "cm")
            {
                outputsizeMetres = sizeMetres * 100M;
                Console.WriteLine("{0} {1}", outputsizeMetres, destMetric);
            }
            else if (destMetric == "mm")
            {
                outputsizeMetres = sizeMetres * 1000M;
                Console.WriteLine("{0} {1}", outputsizeMetres, destMetric);
            }
        }
    }
    }
