using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day02
{
    class SumOfPrimes
    {
       static int Sum = 0;

        static void Main(string[] args)
        {
            First:
            SumOfPrimes obj = new SumOfPrimes();
            Console.Write("Enter Starting From Prime Number  : ");
            int from = int.Parse(Console.ReadLine());
            Console.Write("Enter Ending to Prime Number  : ");
            int to = int.Parse(Console.ReadLine());
            obj.sumOfPrimes(from,to);
            Console.WriteLine($"Sum Of Prime Numbers  : {Sum}");

            Console.WriteLine($"Calling sumOfPrimes multiple times with different values");
            Sum = 0;
            goto First;
        }

        public int sumOfPrimes(int from, int to)
        {

            for (int i = from; i <= to; i++)
            {
                if (IsPrime(i))
                {
                    Sum += i;
                }
            }
            // do stuff here
            return Sum;
        }

        public static bool IsPrime(int i)
        {       
            int m = 0;
            if (i==1)
            {
                return false;
            }
            m = i / 2;
            for (int j = 2; j <= m; j++)
            {
                if(i % j == 0)
                {
                    return false;
                }
            }

            return true;

        }
    }
}
