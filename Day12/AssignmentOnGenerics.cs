using Day01.Day03;
using ImTools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day12
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"{EmpId}-{EmpName}-{EmpAddress}-{Salary}";
        }
    }

    class DataComponent<T> where T:Employee
    {
        string fileName = "Employee.txt";
        List<T> _employee = new List<T>();
        public void Insert(T obj)
        {
            _employee.Add(obj);
            File.AppendAllText(fileName, obj.ToString()+"\n");
        }

        public void DeleteRecord(int id)
        {
            loadRecords();
            var rec = FindById(id);
            saveRecords();
        }

        private Employee FindById(int id)
        {
            var records = _employee.Find((e) => e.EmpId == id);
            if (records == null) throw new Exception("Employee Not Found");
            return records;
        }

        public void UpdateRecord(Employee obj)
        {
            loadRecords();
            var rec = _employee.Find(e => e.EmpId == obj.EmpId);
            rec.EmpName = obj.EmpName;
            rec.EmpAddress = obj.EmpAddress;
            rec.Salary = obj.Salary;
        }
        private void saveRecords()
        {
            string data = string.Empty;
            foreach (var emp in _employee)
            {
                data += emp.ToString();
            }
            File.WriteAllText(fileName, data);
        }
        public List<T> Find(string name)
        {
            loadRecords();
            return _employee.FindAll((e) => e.EmpName.Contains(name));
        }
        private void loadRecords()
        {
            _employee = new List<T>();
           // _employee.Clear();
            var arrayOfLines = File.ReadAllLines(fileName);
            foreach (var line in arrayOfLines)
            {
                var words = line.Split(',');
                T emp = (T)new Employee
                {
                    EmpId = int.Parse(words[0]),
                    EmpName = words[1],
                    EmpAddress = words[2],
                    Salary = int.Parse(words[3])
                };
                _employee.Add(emp);
            }
        }
    }
    class AssignmentOnGenerics
    {
        static DataComponent<Employee> obj = new DataComponent<Employee>();
        static Employee emp = new Employee();
        static string Menu = "----------------------Employee Application---------------------\nInsert Employee ------------ Press 1\nDelete Employee ------------ Press 2\nUpdate Employee ------------ Press 3\nFind Employee   ------------ Press 4";
        static void Main(string[] args)
        {
            bool processing = true;
            do
            {
                var choice=HelperClass.GetNumber(Menu);
                processing = ProcessMenu(choice);
            } while (processing);
        }

        private static bool ProcessMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    CreateEmployee();
                    return true;
                case 2:
                    deleteEmployee();
                    return true;
                case 3:
                    UpdateEmployee();
                    return true;
                case 4:
                    FindEmployee();
                    return true;

            }
            return false;
        }

        private static void FindEmployee()
        {
            var name = HelperClass.GetString("Find Employee By Employee Name");
            obj.Find(name);
        }

        private static void UpdateEmployee()
        {
            emp.EmpId = HelperClass.GetNumber("Enter Employee Id");
            emp.EmpName = HelperClass.GetString("Enter Employee Name");
            emp.EmpAddress = HelperClass.GetString("Enter Employee Address");
            emp.Salary = HelperClass.GetNumber("Enter Employee Salary");
            obj.UpdateRecord(emp);
        }

        private static void deleteEmployee()
        {
            int id = HelperClass.GetNumber("Enter Employee Id For Delete That Employee");
            obj.DeleteRecord(id);
        }

        private static void CreateEmployee()
        {
            emp.EmpId = HelperClass.GetNumber("Enter Employee Id");
            emp.EmpName = HelperClass.GetString("Enter Employee Name");
            emp.EmpAddress = HelperClass.GetString("Enter Employee Address");
            emp.Salary = HelperClass.GetNumber("Enter Employee Salary");
            obj.Insert(emp);
        }
    }
}
