using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score:");

            var number = double.Parse(Console.ReadLine());
            double bonusScore = 0.0;
            {


                if (number <= 100.0)
                {


                    bonusScore += 5.0;
                }




                else if (number > 100 && number <= 999)
                {

                    bonusScore = number * 0.20;
                }


                else if (number > 1000)
                {


                    bonusScore = number * 0.10;
                }








                if (number % 10 == 5)
                {

                    bonusScore += 2.0;
                }

                else if (number % 2 == 0)
                {

                    bonusScore += 1.0;
                }





                Console.WriteLine("BonusScore {0}", bonusScore);


                Console.WriteLine("TotalScore {0} ", bonusScore + number);

            }
        }
    }
}
