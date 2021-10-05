using Day01.Day03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day20
{
    class AssignmentOnLinqtoSql
    {
        static DataManagerDataContext context = new DataManagerDataContext();
        static string menu = "---------Doctor And Patient----------------\nAdd Doctor Press -------->1\nAdd Patient Press -------->2";
        static void Main(string[] args)
        {
            Menu();
            fetchPatientBill();
            Console.ReadLine();
        }
      
        private static void fetchPatientBill()
        {
            int Patient = HelperClass.GetNumber("Enter Id For Which Patient bill You Want");
            var rec = (from pat in context.Patients
                       join doc in context.Doctors on pat.Id equals doc.DocId
                       where pat.Id == Patient
                       select new
                       {
                           doc.Fee,
                           pat.Name
                       }).SingleOrDefault();
           
                Console.WriteLine($"{rec.Name} Total Bill = {rec.Fee}");

        }

        private static void Menu()
        {
            int choice = HelperClass.GetNumber(menu);
            if (choice == 1)
            {
                addDoctor();
            }
            else if (choice == 2)
            {
                addPatient();
            }
        }

        private static void addPatient()
        {
            var pat = new Patient();
            pat.Id = HelperClass.GetNumber("Enter Patient Number");
            pat.Name = HelperClass.GetString("Enter Patient Name");
            pat.ContactNo = HelperClass.GetPhoneNumber("Enter Contact No");
            pat.VisitDate = HelperClass.GetDate("Enter Visit Date");
            pat.DocId = HelperClass.GetNumber("Enter Doctor Id");
            context.Patients.InsertOnSubmit(pat);
            context.SubmitChanges();
            Console.WriteLine("Successfuly Added");
        }

        private static void addDoctor()
        {
            var doc = new Doctor();
            doc.DocId = HelperClass.GetNumber("Enter Doctor Id");
            doc.Name = HelperClass.GetString("Enter Doctor Name");
            doc.Specilization = HelperClass.GetString("Enter Spelization");
            doc.Fee = HelperClass.GetNumber("Enter Fees Salary");
            context.Doctors.InsertOnSubmit(doc);
            context.SubmitChanges();
            Console.WriteLine("Successfuly Added");
        }
    }
}
