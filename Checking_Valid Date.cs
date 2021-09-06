using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Checking_Valid_Date
    {
        const int Max_Year = 9999;
        const int Min_Year = 1800;
        public static void Main()
        {

            Console.WriteLine("Enter The Date ");
            Console.Write("Day : ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Month : ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Year  : ");
            int y = int.Parse(Console.ReadLine());


            if (IsValidDate(d, m, y))
                Console.WriteLine("It is Valid Date");
            else
                Console.WriteLine("No");

            Console.ReadLine();

        }

        public static bool isLeap(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0));
        }
        public static bool IsValidDate(int day,int month,int year)
        {
            if (year > Max_Year || year < Min_Year)
                return false;
            if (month < 1 || month > 12)
                return false;
            if (day < 1 || day > 31)
                return false;

            if(month==2)
            {
                if(isLeap(year))
                {
                    return (day <= 29);
                }
                else
                {
                    return (day <= 28);
                }
            }

            if (month == 4 || month == 6 ||  month == 9 || month == 11)
                return (day <= 30);
            return true;
        }
    }

}
