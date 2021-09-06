using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Real_Numbers
    {
        public static void Main()
        {
            int i, number, sum = 0;
            double avg;

            Console.WriteLine("Enter The 10 Real Numbers");
            for(i=1;i<=10;i++)
            {
                Console.Write("Number-{0} : ", i);
                number = int.Parse(Console.ReadLine());
                sum += number;
            }
            avg = sum / 10.0;
            Console.Write("The Sum of 10 Real Numbers is : {0}\nThe Average is : {1}\n", sum, avg);
            Console.ReadLine();
        }
    }
}
