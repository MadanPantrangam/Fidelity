using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class PrimeNumber
    {

        public static void Main()
        {
            Console.Write("Enter The Number : ");
            int number = int.Parse(Console.ReadLine());
            if (isPrimeNumber(number))
                Console.WriteLine("The Number Is Prime");
            else
                Console.WriteLine("The Number Not Prime Number");
            Console.ReadLine();
        }

        static bool isPrimeNumber(int number)
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    return false;

            }
            return true;
        }
    }
}
