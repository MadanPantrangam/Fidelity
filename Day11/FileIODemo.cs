using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//My Reference


//---------------------------------------------

//These examples will be on file handling in .NET. All Classes related to File handling is available under System.IO
//C# uses streams for handling IO operations. All streams are based on an Abstract class called System.IO.Stream that provides std methods to transfer bytes to the source and vise-versa. ALl Classes that want to read/write bytes from a source must be derived from Stream class and implement methods in them.
//FileStream, MemoryStream, BufferedStream, NetworkStream, PipeStream, CyptoStream.
//StreamReader and StreamWriter are helper classes for reading and writing a string to a stream which internally converts charecters to bytes .
//BinaryReader and BinaryWriter are helper classes for reading/writing primitive data types to and from bytes.
//Binary and Stream readers internally the specific target streams like File, Memory, Buffer, network as sources.
//For text based files, we have a static class called File that contain methods to perform basic reading and writing operations on Text based files.

namespace Day01.Day11
{
    class FileIODemo
    {
        static string getMenu(string fileName)
        {
            if (File.Exists(fileName))
            {
                var content = File.ReadAllText(fileName);
                return content;
            }
            return string.Empty;
        }

        static void fileReading()
        {
            string filePath = @"C:\Users\6133094\Desktop\FNF Trainning\Assignment Programms\Day01\Day01\Day11\FileIODemo.cs";
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File Location is Not Valid!");
            }
        }

        static void MenuReadingDemo(string[] args)
        {
            string Menu = getMenu(args[0]);
            if(string.IsNullOrEmpty(Menu))
            {
                Console.WriteLine("No Menu Found \n Exiting The Application.......");
                return;
            }
            do
            {
                Console.WriteLine(Menu);
                char choice = char.Parse(Console.ReadLine());
                Console.WriteLine($"The Selected Choice Is : {choice}");
            } while (true);
          
        }

        static void Main(string[] args)
        {
            //WriteToFileDemo();
            // appendFileDemo();
            //readFilesBytes();
            DisplayDetailsOfAllFiles();
            Console.ReadLine();
        }

        private static void DisplayDetailsOfAllFiles()
        {
            var files = Directory.GetFiles(@"C:\Users\6133094\Desktop\FNF Trainning\Assignment Programms\Day01\Day01\Day11");
            foreach (var file in files)
            {
                Console.WriteLine($"Details Of Files : {file}");
                var time = File.GetCreationTime(file);
                Console.WriteLine($"File Created On {time.ToString()}");
                 time = File.GetLastAccessTime(file);
                Console.WriteLine($"file last Accessed on {time.ToString()}");
                var attributes = File.GetAttributes(file);
                Console.WriteLine(attributes);
            }
            var drives = Directory.GetLogicalDrives();
            foreach (var drive in drives)
            {
                Console.WriteLine(drive);
            }
        }

        private static void readFilesBytes()
        {
            string fileName = @"C:\Users\6133094\Desktop\FNF Trainning\Assignment Programms\Day01\Day01\Day11\Test.txt";
            FileStream fs = File.Open(fileName, FileMode.Open);
            while (fs.CanRead)
            {
                var byteval = 0;
                if((byteval=fs.ReadByte()) != -1)
                {
                    Console.WriteLine((char)byteval);
                }
            }
        }

        private static void appendFileDemo()
        {
            string fileName = @"C:\Users\6133094\Desktop\FNF Trainning\Assignment Programms\Day01\Day01\Day11\Test.txt";
            Console.WriteLine("please Write Something to Append the Existing file");
            string content = Console.ReadLine();
            File.AppendAllText(fileName, content + "\n");
        }

        private static void WriteToFileDemo()
        {
            Console.WriteLine("please Write Something!!!!!!!");
            string content = Console.ReadLine();
            string fileName = @"C:\Users\6133094\Desktop\FNF Trainning\Assignment Programms\Day01\Day01\Day11\Test.txt";
            File.WriteAllText(fileName, content);
            Console.WriteLine("File Has been written");
            content = getMenu(fileName);
            Console.WriteLine("The Content has follows");
            Console.WriteLine(content);
        }
    }
}
