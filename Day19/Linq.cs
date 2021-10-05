using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day19
{
    static class MyExtensionMethods
    {
        public static int GetNoOfWords(this string args)
        {
            string[] words = args.Split(' ', '.');
            return words.Count();
        }
    }
    class Linq
    {
        static void Main(string[] args)
        {
            //varKeyWord();
          //anonymousTypes();
        // lambdaExpression();
         //extensionMethods();
           linqDemo();
            Console.ReadLine();
        }

        private static void linqDemo()
        {
            var Names = new string[] {
                "Madhan","Suneel","Suda"
            };

            var data = from n in Names
                       select n;
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        private static void extensionMethods()
        {
            string content = "Madhan Pantrangm ";
            var count = content.GetNoOfWords();
            Console.WriteLine("The No Of Words " + count);
        }

        private static void lambdaExpression()
        {
            Action action = () => Console.WriteLine("Welcome to Lamba Expressions");
            Action<int> intaaction = (i) => Console.WriteLine("The Value passed is " + i);
            Func<double, double, double> addFunc = (v1, v2) => v1 + v2;
            action();
            intaaction(7);
            var res= addFunc(987, 762);
            Console.WriteLine(res);

        }

        private static void anonymousTypes()
        {
            var empDetails = new { 
            EmpName="Madan",Address="Mallam",Salary=38000,joindate=DateTime.Now.AddDays(-10)
            };
            Console.WriteLine(empDetails);
            Console.WriteLine(empDetails.EmpName);
            Console.WriteLine(empDetails.Address);
            Console.WriteLine(empDetails.Salary);
            Console.WriteLine(empDetails.joindate.ToShortDateString());
        }

        private static void varKeyWord()
        {
            var Name = "Madan";
            Name = 123.ToString();
            Console.WriteLine(Name.GetType().Name);
        }
    }
}
