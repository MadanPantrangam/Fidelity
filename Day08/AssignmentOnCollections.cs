using System;
using Day01.Day03;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day08
{
    //Assignment:
    /*
     * Create this code in a seperate file and Main program in it which will have the functionalities of a Sign In and Sign Up feature. It should be menu driven and ask the users the choice of either registering or logging in. Let it be an infinite loop. U can close the Console Window when U want to terminate the App.
     * Reimplement the interface of the Bookstore App to store the data into a List instead of Array or DataTable. BookStore app. Using RTP, use this class instance to see the change in the behavior of the project.
     * U can create a static class called BookManager which has static method to return the interface object which will be used by the consumer of this application.
     */
    class AssignmentOnCollections
    {
        static string menu = "---------------Welcome Fidelity National Financial India Ltd.-------------------\nSign In ------------------Press 1\nSign Up ------------------Press 2";
       static Dictionary<string, string> users = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            bool processing = true;
            do
            {
                var choice = HelperClass.GetNumber(menu);
                processing = ProcessMenu(choice);
            } while (processing);

            Console.ReadLine();
        }

        private static bool ProcessMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    SignIn();
                    return true;
                case 2:
                    SignUp();
                    return true;
                default:
                    break;
            }
            return false;
        }

        private static void SignIn()
        {
            string loginName = HelperClass.GetString("Enter User Name : ");
            string logPassword = HelperClass.GetString("Enter Password");
            if (users.ContainsKey(loginName))
            {
                if (users[loginName] == logPassword)
                {
                    Console.WriteLine("Welcome to FNF India Private Limited!!!!!!!!!!");
                }
                else
                {
                    Console.WriteLine("Invalid Password");
                }
            }
            else
            {
                Console.WriteLine("User Name Not Valid");
            }
        }

        private static void SignUp()
        {
            string userName = HelperClass.GetString("Enter The UserName");
            string Password = HelperClass.GetString("Enter The Password");
            if (users.ContainsKey(userName))
            {
                Console.WriteLine("Uesr Name Already Exist please Try Again ");
            }
            else
            {
                users.Add(userName, Password);
            }
        }
    }
}
