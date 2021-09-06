using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of Celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            int kelvin = celsius + 273;
            Console.WriteLine("Kelvin = {0}", kelvin);
            Console.Write("fahrenheit = {0}", celsius * 18 / 10 + 32);
            Console.ReadLine();
        }
    }
}
