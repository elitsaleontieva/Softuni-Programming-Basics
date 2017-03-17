using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double p = int.Parse(Console.ReadLine()); // брой празници без събота и неделя
            double h = int.Parse(Console.ReadLine()); // уикенди за пътуване до родния град
            double uikendiVGodinata = 48;
            double uikendiVSofia = (uikendiVGodinata - h) * 3 / 4;

            double igriVGrada = h;
            double igriVSofia = p * 2 / 3;

            double all = uikendiVSofia + igriVGrada + igriVSofia;
            double ifYear = 0;

            if (yearType == "leap")
            {
                ifYear = (15 * all) / 100;
            }
            double final = Math.Truncate(ifYear + all);
            Console.WriteLine(final);
        }
    }
}
