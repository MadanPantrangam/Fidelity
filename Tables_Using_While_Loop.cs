using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Tables_Using_While_Loop
    {
        public static void Main()
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            int i = 1, j = 10;
            while(i<=j)
            {
                int temp = i * number;
                Console.WriteLine(number + "x" + i + "=" + temp);
                i++;
            }
            Console.ReadLine();
        }
    }
}
