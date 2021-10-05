using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day09
{
    class Person : IComparable<Person>
    {
        public int Id, Salary;
        public string Name;

        public int CompareTo(Person other)
        {
            if (Salary < other.Salary)
                return -1;
            else if (Salary > other.Salary)
                return 1;
            else
                return 0;
        }
        public override string ToString()
        {
            return $"Name : {Name} Salary : {Salary}";
        }
    }
    class PersonDB : IEnumerable<Person>
    {
        private List<Person> _persons=new  List<Person>();
        public void AddPerson(int id,string name,int salary)
        {
            var Person = new Person { Id = id, Name = name, Salary = salary };
            _persons.Add(Person);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return _persons.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var person in _persons)
            {
                yield return person;
            }
        }

        public int Total { get => _persons.Count; }

        public Person this[int index]
        {
            get
            {
                if(index<0||index>=_persons.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of Range");
                }
                return _persons[index];
            }
        }

        public Person this[string Name]
        {
            get
            {
                foreach (var p in _persons)
                {
                    if (p.Name == Name)
                        return p;
                }
                throw new IndexOutOfRangeException("Name Not Found");
            }
        }

        public List<Person> Sort()
        {
                _persons.Sort();
                return _persons;
        }
    }
    class AdvancedCollections
    {
        static void Main(string[] args)
        {
           // iterartorExample();
            PersonDB db = new PersonDB();
            db.AddPerson(123, "Madan", 50000);
            db.AddPerson(124, "Ram", 60000);
            db.AddPerson(125, "Sam", 70000);
            db.AddPerson(126, "Raj", 80000);
            db.AddPerson(127, "Pooja", 90000);
            var list = db.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
 
            Console.ReadLine();
        }

        private static void iterartorExample()
        {
            var db = new PersonDB();
            db.AddPerson(123, "Madan", 50000);
            db.AddPerson(124, "Ram", 60000);
            db.AddPerson(125, "Sam", 70000);
            db.AddPerson(126, "Raj", 80000);
            db.AddPerson(127, "Pooja", 90000);
            Console.WriteLine($"The no of pepople here {db.Total}");
            for (int i = 0; i < db.Total; i++)
            {
                Console.WriteLine(db[i].Name);
            }
            Console.WriteLine("--------------Using Iterator--------------");
            var iterator = db.GetEnumerator();
            while (iterator.MoveNext())
                Console.WriteLine(iterator.Current);
        }
    }
}
