using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthDay = (Console.ReadLine());
            DateTime convertBirthDay = DateTime.ParseExact(birthDay, "dd-MM-yyyy", null);

            DateTime after1000 = convertBirthDay.AddDays(999);
            string dateFormat = "dd-MM-yyyy";
            string strDate = after1000.ToString(dateFormat);

            Console.WriteLine(strDate);
        }
    }
}
