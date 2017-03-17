using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var USD = 1.79549;
            var EUR = 1.95583;
            var GBP = 2.53405;
            var x = double.Parse(Console.ReadLine());
            var firstCurency = Console.ReadLine();
            var secondCerrency = Console.ReadLine();
            var moneyInleva = 0.00;

            if (firstCurency == "USD") { moneyInleva = x * USD; }
            else if (firstCurency == "EUR") { moneyInleva = x * EUR; }
            else if (firstCurency == "GBP") { moneyInleva = x * GBP; }
            else if (firstCurency == "BGN") { moneyInleva = x; }


            var MoneyInWanted = 0.00;
            if (secondCerrency == "USD") { MoneyInWanted = moneyInleva / USD; }
            else if (secondCerrency == "EUR") { MoneyInWanted = moneyInleva / EUR; }
            else if (secondCerrency == "GBP") { MoneyInWanted = moneyInleva / GBP; }
            else if (secondCerrency == "BGN") { MoneyInWanted = moneyInleva; }

            Console.WriteLine("{0:0.00} {1}", MoneyInWanted, secondCerrency);
        }
    }
}
