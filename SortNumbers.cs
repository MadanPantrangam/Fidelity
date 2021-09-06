using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class SortNumbers
    {
        public static void Main()
        {
            sortThreeNumbers(3, 5, 6);
            sortThreeNumbers(10, 2, 7);
            sortThreeNumbers(4, 10, 1);
            Console.ReadLine();
        }

        public static void sortThreeNumbers(int a, int b, int c)
        {
            if ((a <= b) && (a <= c))
            {
                if (b <= c)
                    Console.WriteLine(a + "\t" + b + "\t" + c);
                else
                    Console.WriteLine(a + "\t" + c + "\t" + b);
            }
            else if ((b <= a) && (b <= c))
            {
                if (a <= c)
                    Console.WriteLine(b + "\t" + a + "\t" + c);
                else
                    Console.WriteLine(b + "\t" + c + "\t" + a);
            }
            else
            {
                if (a <= b)
                    Console.WriteLine(c + "\t" + a + "\t" + b);
                else
                    Console.WriteLine(c + "\t" + b + "\t" + a);
            }

        }


    }
}


