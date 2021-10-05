using Day01.Day03;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day01.Day11
{
    interface IEmployeeDemo
    {
        void AddNewEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void DeleteEmployee(int id);
        Employee FindById(int id);
        List<Employee> FindByName(string name);
        List<Employee> FindByAddress(string address);
    }

    [Serializable]
    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return $"{EmpId},{Name},{Address},{Salary}";
        }
    }
    class EmployeeDB : IEmployeeDemo
    {
        List<Employee> _employees = new List<Employee>();
        string fileName = "Employee.csv";
        private void saveRecords()
        {
            string data = string.Empty;
            foreach (var emp in _employees)
            {
                data += emp.ToString();
            }
            File.WriteAllText(fileName, data);
        }

        public void loadRecords()
        {
            _employees.Clear();
            var arrayOfLines = File.ReadAllLines(fileName);
            foreach (var line in arrayOfLines)
            {
                var words = line.Split(',');
                var emp = new Employee
                {
                    EmpId = int.Parse(words[0]),
                    Name = words[1],
                    Address=words[2],
                    Salary=int.Parse(words[3])
                };
                _employees.Add(emp);
            }
        }
        public void AddNewEmployee(Employee emp)
        {
            _employees.Clear();
            if (emp == null) throw new Exception("Employee Details are not set, so U cannot store the details");
            //  _employees.Add(emp);
            File.AppendAllText(fileName, emp.ToString() + "\n");
        }
        public void UpdateEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }
        public void DeleteEmployee(int id)
        {
            loadRecords();
            var rec = FindById(id);
           _employees.Remove(rec);
            saveRecords();
        }
        public List<Employee> FindByName(string name)
        {
            var records = _employees.FindAll((e) => e.Name.Contains(name));
            return records;
        }
        public List<Employee> FindByAddress(string address)
        {
            var rec = _employees.FindAll((e) => e.Address.Contains(address));
            return rec;
        }
        public Employee FindById(int id)
        {
            var records = _employees.Find((e) => e.EmpId == id);
            if (records == null) throw new Exception("Employee Not Found");
            return records;
        }
        class FileAssignment
        {
            static string Menu = "----------------------Employee Application---------------------\nAdd Employee ------------ Press 1\nDelete Employee ------------ Press 2\nUpdate Employee ------------ Press 3\nFind Employee  By Id ------------ Press 4\nFind Employee  By Address ------------ Press 5\nFind Employee  By Name ------------ Press 6";

            static EmployeeDB app = new EmployeeDB();
            static Employee emp = new Employee();
            static void Main(string[] args)
            {

                bool processing = true;
                do
                {
                    var choice = HelperClass.GetNumber(Menu);
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
                        FindEmployeeByID();
                        return true;
                    case 5:
                        FindEmployeeByAddress();
                        return true;
                    case 6:
                        FindEmployeeByName();
                        return true;

                }
                return false;
            }

            private static void FindEmployeeByName()
            {
                string name = HelperClass.GetString("Enter Employee Name For Find That Employee");
                app.FindByName(name);
            }

            private static void FindEmployeeByAddress()
            {
                string Address = HelperClass.GetString("Enter Employee Address For Find That Employee");
                app.FindByAddress(Address);
            }

            private static void FindEmployeeByID()
            {
                int id = HelperClass.GetNumber("Enter Employee Id For Find That Employee");
                app.FindById(id);
            }

            private static void UpdateEmployee()
            {
                emp.EmpId = HelperClass.GetNumber("Enter Employee Id");
                emp.Name = HelperClass.GetString("Enter Employee Name");
                emp.Address = HelperClass.GetString("Enter Employee Address");
                emp.Salary = HelperClass.GetNumber("Enter Employee Salary");
                app.UpdateEmployee(emp);
            }

            private static void deleteEmployee()
            {
                var id = HelperClass.GetNumber("Enter Employee Id For Delete That Employee");
                app.DeleteEmployee(id);
            }

            private static void CreateEmployee()
            {
                emp.EmpId = HelperClass.GetNumber("Enter Employee Id");
                emp.Name = HelperClass.GetString("Enter Employee Name");
                emp.Address = HelperClass.GetString("Enter Address");
                emp.Salary = HelperClass.GetNumber("Enter Salary");
                app.AddNewEmployee(emp);
            }
        }
    }
}



