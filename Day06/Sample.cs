using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day06
{

    class HelperClass
    {
        public static uint GetNumber(string question)
        {
            uint res;
            Console.WriteLine(question);
            if(!uint.TryParse(Console.ReadLine(),out res))
            {
                Console.WriteLine("Ivalid Number the Range Of Unsigned Int is {0} to {1}",0,uint.MaxValue);
            }
            return res;
        }

        public static double GetDouble(string question)
        {
            double res;
            Console.WriteLine(question);
            if (!double.TryParse(Console.ReadLine(), out res))
            {
                Console.WriteLine("Ivalid Number the Range Of Unsigned Int is {0} to {1}", double.MinValue, double.MaxValue);
            }
            return res;
        }

        public static DateTime GetDate(string question)
        {
            DateTime res;
            Console.WriteLine(question);
            res = DateTime.Parse(Console.ReadLine());
            return res;
        }

        public static string GetString(string question)
        {
            string res;
            Console.WriteLine(question);
            res = Console.ReadLine();
            return res;
        }
    }
}
