using Day01.Day03;
using System;

namespace Day01.Day04
{
    class Calculator
    {
        static void Main(string[] args)
        {
            
            double value1 = HelperClass.GetNumber("Enter Value 1 :");
            double value2 = HelperClass.GetNumber("Enter Value 2 : ");
            Console.WriteLine("What Operations You Want : ");
            Console.WriteLine("1.Addition \n 2.Subtaction\n3.Multiplication \n4.Division");
            Console.WriteLine("================================="); 
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine($"You Selected {choice} Option");
            
            switch (choice)
            {
                case 1:
                    // double temp = value1 + value2;
                   var temp = Addition(value1,value2);
                    Console.WriteLine($"{value1}+{value2} = {temp}");
                    break;
                case 2:
                    //double temp1 = value1 - value2;
                  var temp1 =  Subtraction(value1, value2);
                    Console.WriteLine($"{value1}-{value2} = {temp1}");
                    break;
                case 3:
                    //double temp3 = value1 * value2;
                   var temp3 = Multiplication(value1, value2);
                    Console.WriteLine($"{value1}x{value2} = {temp3}");
                    break;
                case 4:
                    //double temp4 = value1 / value2;
                   var temp4 = Division(value1, value2);
                    Console.WriteLine($"{value1}/{value2} = {temp4}");
                    break;
                default:
                    Console.WriteLine("You Selected Wrong Operation");
                    Console.WriteLine("You are Continue Enter Yes Orelse ");
                    break;
            }
           
           
            Console.ReadLine();
        }

       
        public static double Addition(double val1,double val2)
        {
            double result=val1+val2;

            return result;
        }
        public static double Subtraction(double val1, double val2)
        {
            double result = val1 - val2;

            return result;
        }
        public static double Multiplication(double val1, double val2)
        {
            double result = val1 * val2;

            return result;
        }
        public static double Division(double val1, double val2)
        {
            double result = val1 / val2;

            return result;
        }


    }
}
