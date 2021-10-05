using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Day01.Day19
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public int EmpSalary { get; set; }
    }



    static class FileData
    {
        const string filename = @"C:\Users\6133094\Desktop\FNF Trainning\Assignment Programms\Day01\Day01\Day19\Employee.csv";
        public static List<Employee> GetAllEmployees()
        {
            if (!File.Exists(filename))
                throw new FileNotFoundException("No File Found");
            var list = new List<Employee>();
            var lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                var words = line.Split(',');
                var emp = new Employee
                {
                    EmpID = int.Parse(words[0]),
                    EmpName = words[1],
                    EmpSalary = int.Parse(words[3]),
                    EmpCity = words[2]
                };
                list.Add(emp);
            }
            return list;
        }
    }
    class LinqDemoProgram
    {
        static List<Employee> theList = FileData.GetAllEmployees();
        static void Main(string[] args)
        {
            //readOnlyNames();
            //readNamesWithCity();
            // whereClauseExample();
            //OrderByClause();
            //groupByClause();
            Console.ReadLine();
        }

        private static void groupByClause()
        {
            var groups = from emp in theList
                         group emp.EmpName by emp.EmpCity into gr
                         orderby gr.Key
                         select gr;
            foreach (var gr in groups)
            {
                Console.WriteLine("The City : "+gr.Key );
                foreach (var name in gr)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("------------------------------------");
            }
        }

        private static void OrderByClause()
        {
            var results = from emp in theList
                          orderby emp.EmpCity descending
                          select emp.EmpCity;
            foreach (var item in results.Distinct())
            {
                Console.WriteLine(item);
            }
        }

        private static void whereClauseExample()
        {
            var data = from emp in theList
                       where emp.EmpCity == "Chennai" && emp.EmpName.StartsWith("C")
                       select emp.EmpName;
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        private static void readNamesWithCity()
        {
            var data = from emp in theList
                       select new { emp.EmpName, emp.EmpCity };
            foreach (var item in data)
            {
                Console.WriteLine($"{item.EmpName} from {item.EmpCity}");
            }
        }

        private static void readOnlyNames()
        {
            var names = from emp in theList
                        select emp.EmpName;
            foreach (var name in names) Console.WriteLine(name);
        }
    }
}