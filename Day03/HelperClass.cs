using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day03
{
    class HelperClass
    {
        public static int GetNumber(string question)
        {
            Console.WriteLine(question);
            var Number = int.Parse(Console.ReadLine());
            return Number;
        }

        public static string GetString(string question)
        {
            Console.WriteLine(question);
            var sub = Console.ReadLine();
            return sub;
        }

        public static DateTime GetDate(string question)
        {
            Console.WriteLine(question);
            var dob = DateTime.Parse(Console.ReadLine());
            return dob;
        }
    }
}
