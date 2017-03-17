using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxnum = -2147483648;
            int numbercount = int.Parse(Console.ReadLine());
            for (int currnum = 0; currnum < numbercount; currnum++)
            {

                int userinput = int.Parse(Console.ReadLine());

                if (maxnum < userinput)
                {
                    maxnum = userinput;
                }
            }
            Console.WriteLine(maxnum);
        }
    }
    }
