using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day07
{
    /*
     
 Exception handing is not error handling. It is a situation where an app fails to move forward because of some issue either with data entry, logical mistake or any other reason that stops the execution of the program. U handle such situations in ur code using try..catch...finally blocks and handle those abnormal exits.
All Exceptions raised in UR program are raised as objects of a class derived from System.Exception. The EException class is the base class for all Exceptions that are raised by the Runtime when U execute the program. Exception can be system based or Application based. Custom Exceptions will be app based. 
Exceptions are handled using try...catch...finally blocks. U must start with a try block and follow it by catch/multiple catch/finally blocks. U cannot start with catch and finally.
 
UR Code can raise an exception by creating an object of the class derived from System.Exception and using throw keyword U could throw the exception to the Application.
throw will exit the try block and find its matching catch block, if not found, exits the function and goes to the caller block until it finds a matching catch or Main function which will terminate the app...   
U can create Custom Exceptions by creating a class derived from System.ApplicationException which will be used to raise the exception based on UR app requirements.
 */
     
    class AccountNotFoundException : ApplicationException
    {
        public AccountNotFoundException()
        {
            //Default Constructor
        }

        public AccountNotFoundException(string msg):base(msg)
        {

        }

        public AccountNotFoundException(string msg,Exception exception):base(msg,exception)
        {

        }
    }
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            Try:
            Console.WriteLine("Enter a Valid Number!");
            try
            {
                int number = int.Parse(Console.ReadLine());
                throw new AccountNotFoundException("Account Not found to delete");
            }
            catch(FormatException)
            {
                Console.WriteLine("Number Should be a integer Value");
                goto Try;
            }
            catch(OverflowException)
            {
                Console.WriteLine($"Value Should be in {int.MinValue} and {int.MaxValue}");
                goto Try;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Try;
            }
        }
    }
}
