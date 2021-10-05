using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day12
{
    class DataStore<T>
    {
        List<T> data = new List<T>();
        public void Add(T a)
        {
            data.Add(a);
            File.AppendAllText("Data.txt", (a.ToString() + "\n"));
        }

        public void Delete(T a)
        {
            var item = Find(a);
            data.Remove(item);
        }

        public T Find(T a)
        {
            return data.Find(obj => obj.Equals(a));
        }

        public List<T> GetAll()
        {
            var lines = File.ReadAllLines("Data.txt");
            List<T> temp = new List<T>();
            foreach (var line in lines)
            {
                temp.Add((T)Convert.ChangeType(line, typeof(T)));
            }
            return temp;
        }
    }
    class GenericsDemo
    {
        static void Main(string[] args)
        {
            //DataStore<string> sData = new DataStore<string>();
            //sData.Add("Madan");
            //DataStore<int> iData = new DataStore<int>();
            //iData.Add(3456);
            DataStore<string> Names = new DataStore<string>();
            //Names.Add("Madan"+"\n");
            //Names.Add("Suneel"+"\n");
            //Names.Add("Jaya Suda"+"\n");
            //Names.Add("Ram");
            //var data= Names.GetAll();
            // foreach (var item in data)
            // {
            //     Console.WriteLine(item);
            // }
            Names.Delete("Madan");

            Console.ReadLine();
        }
    }
}
