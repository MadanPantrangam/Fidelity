using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day02
{
    class FibonacciSeries
    {
        int index;
        static void Main(string[] args)
        {
            int fibo;
            FibonacciSeries obj = new FibonacciSeries();
            Console.WriteLine("Enter The Number  : ");
            int number = int.Parse(Console.ReadLine());
            if(number==1)
            {
                fibo = 0;
            }
            else if(number == 2)
            {
                fibo = 1;
            }
            else
            {
                fibo = obj.Fibonacci(number);
            }

            Console.Write($"The Index Of {number} is {fibo}");

            Console.ReadLine();
            }

        public  int Fibonacci(int number)
        {

            int n1 = 0, n2 = 1, n3, i;
            for (i = 2; i <number; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                index = n3;
                
            }
            return index;
        }

    }

        

}
