using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day01.Day19
{
    class XLinqDemo
    {
        static void Main(string[] args)
        {
            //ConvertListToxml();
            displayNamesFromFiles();
            //displayNamesAndSalaryFromFile();
            //insertEmployeeToXml();
            //deleteEmployeeInXmlById();
            insertEmployeeToXmlById();
            Console.ReadLine();
        }
        private static void insertEmployeeToXmlById()
        {
            Console.WriteLine("Enter the Id of the Employee where U want to add");
            string id = Console.ReadLine();
            XDocument doc = XDocument.Load("Employees.xml");
            var selectedElement = (from element in doc.Descendants("Employee")
                                   where element.Element("EmpID").Value == id
                                   select element).FirstOrDefault();
            if (selectedElement == null)
            {
                Console.WriteLine("No element found");
            }
            else
            {
                var newElement = new XElement("Employee",
                new XElement("EmpID", 502),
                new XElement("EmpName", "Rahul"),
                new XElement("EmpSalary", 55000),
                new XElement("EmpCity", "Hyderabad")
                );
                selectedElement.AddAfterSelf(newElement);
                doc.Save("employees.xml");
            }
        }


        private static void deleteEmployeeInXmlById()
        {
            Console.WriteLine("Enter the Id of the employee to delete");
            string id = Console.ReadLine();
            XDocument doc = XDocument.Load("Employees.xml");
            var foundelement = (from element in doc.Descendants("Employee")
                                where element.Element("EmpID").Value == id
                                select element).SingleOrDefault();
            foundelement.Remove();
            doc.Save("Employee.xml");
        }
        private static void insertEmployeeToXml()
        {
            XDocument doc = XDocument.Load("Employees.xml");
            //where to insert : at the last
            var last = doc.Descendants("Employee").Last();
            //data to insert
            var element = new XElement("Employee",
            new XElement("EmpID", 501),
            new XElement("EmpName", "Rahul"),
            new XElement("EmpCity", "Bangalore"),
            new XElement("EmpSalary", 60000));
            //insert the record
            last.AddAfterSelf(element);
            //save the file
            doc.Save("Employees.xml");
        }
        private static void displayNamesAndSalaryFromFile()
        {
            XDocument doc = XDocument.Load("Employees.xml");
            var elements = from element in doc.Descendants("Employee")
                           select new
                           {
                               Name = element.Element("EmpName").Value,
                               Salary = element.Element("EmpSalary").Value
                           };
            foreach (var element in elements) Console.WriteLine(element);
        }
        private static void displayNamesFromFiles()
        {
            XDocument doc = XDocument.Load("Employees.xml");
            var elements = from element in doc.Descendants("Employee")
                           select element.Element("EmpName");
            foreach (var element in elements) Console.WriteLine(element.Value);
        }

        private static void ConvertListToxml()
        {
            var data = FileData.GetAllEmployees();
            var root = new XElement("ListOfEmployess", from emp in data
                                                       select new XElement("Employee",
                                                        new XElement("EmpId", emp.EmpID),
                                                        new XElement("EmpName", emp.EmpName),
                                                        new XElement("EmpCity", emp.EmpCity),
                                                        new XElement("EmpSalary", emp.EmpSalary)
                                                       ));
            root.Save("Employees.xml");
        }
    }
}
