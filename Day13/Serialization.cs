using System;
using System.Collections.Generic;
using binary = System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day01.Day03;

namespace Day01.Day13
{
     public class Employee
    {
        public override string ToString()
        {
            return $"{EmpId}-{EmpName}";
        }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }
    class Serialization
    {

        static void Main(string[] args)
        {
            //xmlSerialize();
            xmlDeserialize();
            //NormalSerilize(args);
            Console.ReadLine();
        }

        private static void NormalSerilize(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Invalid Choice");
                return;
            }
            else
            {
                if (args[0] == "Save")
                {
                    serialize();
                }
                else
                {
                    deSerialize();
                }
            }
        }

        private static void xmlDeserialize()
        {
            XmlSerializer fm = new XmlSerializer(typeof(Employee));
            FileStream fs = new FileStream("Data.xml", FileMode.Open, FileAccess.Read);
            var emp = fm.Deserialize(fs) as Employee;
            Console.WriteLine(emp);
        }

        private static void xmlSerialize()
        {
            Employee emp = new Employee();
            emp.EmpId = HelperClass.GetNumber("Enter Employee Id");
            emp.EmpName = HelperClass.GetString("Enter Employee Name");
            XmlSerializer fm = new XmlSerializer(typeof(Employee));
            FileStream fs = new FileStream("Data.xml", FileMode.OpenOrCreate, FileAccess.Write);
            fm.Serialize(fs, emp);
            fs.Close();
        }

        private static void deSerialize()
        {
            Employee emp;
            binary.BinaryFormatter fm = new binary.BinaryFormatter();
            FileStream fs = new FileStream("Data.Bin", FileMode.Open, FileAccess.Read);
            object boxedData = fm.Deserialize(fs);
            if(boxedData is Employee)
            {
                emp = boxedData as Employee;
                Console.WriteLine(emp);
            }
            fs.Close();
        }

        private static void serialize()
        {
            Employee emp = new Employee();
            emp.EmpId = HelperClass.GetNumber("Enter Employee Id");
            emp.EmpName = HelperClass.GetString("Enter Employee Name");
            binary.BinaryFormatter fm = new binary.BinaryFormatter();
            FileStream fs = new FileStream("Data.Bin", FileMode.OpenOrCreate, FileAccess.Write);
            fm.Serialize(fs, emp);
            fs.Close();
        }
    }
}
