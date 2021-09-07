using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day02
{
    class ArrayOfNames
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Size Of The Array :  ");
            int size = int.Parse(Console.ReadLine());
            string[] Names = new string[size];


            for (int i = 0; i < size; i++)
            {
                Console.Write($"Please Enter Name  : ");
                Names[i] = Console.ReadLine();
            }

            Console.WriteLine("Given Names are : ");
            foreach (var Name in Names)
            {
                Console.WriteLine(Name);
            }

            Console.ReadLine();
        }
    }
}
