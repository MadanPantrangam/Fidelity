using System;
using Day01.Day03;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day08
{
    class Book
    {
        public override string ToString()
        {
            return $"BookId {BookId} ,Author = {Author} , Price = {Price}";
        }
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

        public void AddNewBook(Book bk)
        {
            book.BookId = bk.BookId;
            book.Title = bk.Title;
            book.Author = bk.Author;
            book.Price = bk.Price;
            booksData.Add(bk);
        }

        public void DeleteBook(int id)
        {
            try
            {
                var itemRemove = booksData.Single(x => x.BookId == id);
                booksData.Remove(itemRemove);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
        //My Reference
        //public Book[] FindBooksByAuthor(string authorName)
        //{
        //    var temp = new List<Book>();//Create a Temp List with 0 elements in it..
        //    foreach (var bk in _books)//Use foreach loop to search thro the collection
        //    {
        //        if (bk.Author == authorName)//Use if condition to find the matching book with author
        //        {
        //            temp.Add(bk);//Add this matching book to this temp List...
        //        }
        //    }
        //    if (temp.Count == 0) throw new BookStoreException($"No Book is found written by {authorName}");
        //    //if the Temp List Count is 0, throw the exception....
        //    return temp;
        //    //return Temp List converted to an array
        public List<Book> FindBooks(string title)
        {
            var temp = new List<Book>();
            foreach (var book in booksData)
            {
                if (book.Title==title)
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
    class BookStoreOnLists
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
