using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day01.Day19
{
    class AssignmentOnLinq
    {
        private static void insertEmployeeToDB()
        {
            var _employees = convertXmlToList();
            foreach (var item in _employees)
            {
                insertSingleRow(item);
            }
        }
        private static void insertSingleRow(Employee item)
        {
            string strConnection = @"Data Source=.\SQLEXPRESSNEW;Initial Catalog=TrainningDB;Integrated Security=True";
            var connection = new SqlConnection(strConnection);
            var query = "Insert into Employees values(@id,@name,@city,@salary)";
            var cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", item.EmpID);
            cmd.Parameters.AddWithValue("@name", item.EmpName);
            cmd.Parameters.AddWithValue("@city", item.EmpCity);
            cmd.Parameters.AddWithValue("@salary", item.EmpSalary);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Dispose();
                cmd.Dispose();
            }
        }
        private static List<Employee> convertXmlToList()
        {
            XDocument doc = XDocument.Load("Employees.xml");
            var elements = from element in doc.Descendants("Employee")
                           select new
                           {
                               Id = element.Element("EmpID").Value,
                               Name = element.Element("EmpName").Value,
                               City = element.Element("EmpCity").Value,
                               Salary = element.Element("EmpSalary").Value
                           };
            List<Employee> _employee = new List<Employee>();
            var employee = new Employee();
            foreach (var element in elements)
            {
                var emp = new Employee();
                emp.EmpID = Convert.ToInt32(element.Id);
                emp.EmpName = element.Name;
                emp.EmpCity = element.City;
                emp.EmpSalary = Convert.ToInt32(element.Salary);
                _employee.Add(emp);
            }
            return _employee;
        }


        static void Main(string[] args)
        {
            insertEmployeeToDB();
            Console.ReadLine();
        }
    }
}
