using System;
using Day01.Day03;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day08
{
    /*
     //Dictionary is a DS that stores the data in the form of KEY-VALUE pairs. In this case, the Key is unique to the collection and value may or may not be unique. username-password, Dictionary of words: Word is unique, meaning may not be unique. Dictionary is very fast in iteration and reading the data. But it occupies a lot of memory for large size.
     */
    class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return PersonId.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                var temp = obj as Person;
                return temp.PersonId == PersonId;
            } else 
                return false;
           
        }
    }
    class CollectionsDemo
    {

        private static void ObjectSetDemo()
        {
            HashSet<Person> person = new HashSet<Person>();
            person.Add(new Person { Name = "Madhan", PersonId = 1 });
            person.Add(new Person { Name = "Madhan", PersonId = 4 });
            person.Add(new Person { Name = "Madhan", PersonId = 1 });
            person.Add(new Person { Name = "Madhan", PersonId = 2 });
            person.Add(new Person { Name = "Madhan", PersonId = 1 });
            person.Add(new Person { Name = "Madhan", PersonId = 1 });
            foreach (var item in person)
            {
                Console.WriteLine(item);
            }
        }
        static List<string> fruits = new List<string>();
        static void Main(string[] args)
        {
            //HashSet is very similar to List<T> except that it stores only unique values in it. It is basically a Set, Sets are supposed to store only unique values in them. It uses HashCode of the object to determine the uniquness of it. HashCode is a hexadecimal value to identify an object in the CLR.
            //HashSetExample();
            // DisplayFruits();
            // ObjectSetDemo();
            DictionarExample();
            Console.ReadLine();
        }

        private static void DictionarExample()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            for (int i = 0; i < 2; i++)
            {
                string userName = HelperClass.GetString("Enter The UserName");
                string Password = HelperClass.GetString("Enter The Password");
                if(users.ContainsKey(userName))
                {
                    Console.WriteLine("Uesr Name Already Exist please Try Again ");
                }
                else
                {
                    users.Add(userName, Password);
                }
            }

            string loginName = HelperClass.GetString("Enter User Name : ");
            string logPassword = HelperClass.GetString("Enter Password");
            if(users.ContainsKey(loginName))
            {
                if(users[loginName]==logPassword)
                {
                    Console.WriteLine("Welcome User");
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

        private static void HashSetExample()
        {
            HashSet<string> myBasket = new HashSet<string>();
            myBasket.Add("Apple");
            myBasket.Add("Banana");
            foreach (var item in myBasket)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(myBasket.Count);
        }

        private static void DisplayFruits()
        {
            List<string> fruits = new List<string>() { "Mango","Orange","Grapes"};
            string fruit = HelperClass.GetString("Enter Fruit Name : ");
            fruits.Add(fruit);
            Console.WriteLine("The Fruits Count is"+fruits.Count);
            fruits.RemoveAt(1);
            fruits.Insert(3, "Sugar Cane");
            fruits.Remove(HelperClass.GetString("Enter What Fruit Name You Want Delete!"));
            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }
        }
    }
}
