using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Day01.Day03;

namespace Day01.Day11
{
    class Book
    {
       
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
    }

    interface IBookStore
    {
        void AddNewBook(Book bk);
        void UpadateBook(Book bk);
        void DeleteBook(int id);
        List<Book> FindBooks(string title);
    }
    
    class BookStoreException : ApplicationException
    {
        public BookStoreException() { }
        public BookStoreException(string msg) : base(msg) { }
        public BookStoreException(string msg, Exception ex) : base(msg, ex) { }
    }
    class BookStore : IBookStore
    {
        Book book = new Book();
        public List<Book> booksData = new List<Book>();
        Book[] array = new Book[] { };

        string fileName = "BookStore.csv";
        private void SaveRecords()
        {
            string data = string.Empty;
            foreach(var book in booksData)
            {
                data += book.ToString();
            }
            File.WriteAllText(fileName, data);
        }

        public void loadRecords()
        {
            booksData.Clear();
            var arrayOfLines = File.ReadAllLines(fileName);
            foreach (var line in arrayOfLines)
            {
                var words = line.Split(',');
                var book = new Book
                {
                    BookId = int.Parse(words[0]),
                    Title = words[1],
                    Author = words[2],
                    Price = int.Parse(words[3])
                };
                booksData.Add(book);
            }
        }
        public void AddNewBook(Book bk)
        {
            booksData.Clear();
            if (bk == null) throw new Exception("Book Details are not set, so U cannot store the details");
            // booksData.Add(bk);
            File.AppendAllText(fileName, bk.ToString() + "\n");

        }

        public void DeleteBook(int id)
        {
            try
            {
                var itemRemove = booksData.Single(x => x.BookId == id);
                booksData.Remove(itemRemove);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public List<Book> FindBooks(string title)
        {
            var temp = new List<Book>();
            foreach (var book in booksData)
            {
                if (book.Title == title)
                {
                    temp.Add(book);
                }
            }
            if (temp.Count == 0) throw new BookStoreException($"No Book is found written by { title }");
            return temp;
        }




        public void UpadateBook(Book bk)
        {
            var itemToRemove = booksData.Single(r => r.BookId == bk.BookId);
            booksData.Remove(itemToRemove);
            booksData.Add(bk);
        }
    }
    class AssignmentOnFileIOOnBookStore
    {
        const string menu = "----------Book Store APP--------------------\nTO ADD New Book--------->PRESS 1\nTO DELETE Book------------->PRESS 2\nTO UPDATE Book-------->PRESS 3\nTO FIND Book DETAILS---->PRESS 4\n";
        static BookStore app = new BookStore();
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
        public static bool ProcessMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddNewBookDetails();
                    return true;
                case 2:
                    DeleteBookDetails();
                    return true;
                case 3:
                    UpdateBookDetails();
                    return true;
                case 4:
                    FindingBookDetails();
                    return true;

            }
            return false;
        }
        public static void AddNewBookDetails()
        {
            Book book = new Book();
            book.BookId = HelperClass.GetNumber("Enter BookId");
            book.Title = HelperClass.GetString("Enter Book Title");
            book.Author = HelperClass.GetString("Enter Author Name");
            book.Price = HelperClass.GetNumber("Enter Price");
            app.AddNewBook(book);
        }

        public static void DeleteBookDetails()
        {
            int id = HelperClass.GetNumber("Enter Book Number For Delete");
            app.DeleteBook(id);
            Console.WriteLine("The Book With Id {0} is deleted from the DataTable", id);
        }

        private static void UpdateBookDetails()
        {
            Book book = new Book();
            book.BookId = HelperClass.GetNumber("Enter BookId");
            book.Author = HelperClass.GetString("Enter Author Name");
            book.Title = HelperClass.GetString("Enter Title Name");
            book.Price = HelperClass.GetNumber("Enter Book Price");
            app.UpadateBook(book);
        }

        private static void FindingBookDetails()
        {
            Book obj = new Book();
            string value = HelperClass.GetString("Find The Book");
            var data = app.FindBooks(value);
            foreach (var item in data)
            {
                Console.WriteLine($"Book Id = {item.BookId} Author Name :  {item.Author} Book title :  {item.Title} Book Price  : {item.Price}");
            }
        }
    }
}
