using Day01.Day03;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day07
{
    /*
* Create an interface called IBookStore: Add, Delete, Find and Update functions to perform the operations.
* Create a class that represents a book: ID, Title, Author, Price as properties.
* Create a class that implements this interface and the internal data structure will be Book array.
* Create a UI Component that will have functions to perform all the operations using a menu driven program.
*/
    #region Entities
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
    #endregion

    #region DataLAyer
    interface IBookStore
    {
        void AddNewBook(Book bk);
        void UpadateBook(Book bk);
        void DeleteBook(int id);
        DataTable FindBooks(string title);
    }

    class BookStore : IBookStore
    {
        public DataTable booksTable = new DataTable("Book Table");
        public BookStore()
        {
            booksTable.Columns.Add("BookId", typeof(int));
            booksTable.Columns.Add("Title", typeof(string));
            booksTable.Columns.Add("Author", typeof(string));
            booksTable.Columns.Add("Price", typeof(double));

        }

        public void AddNewBook(Book bk)
        {
            DataRow row = booksTable.NewRow();
            row[0] = bk.BookId;
            row[1] = bk.Title;
            row[2] = bk.Author;
            row[3] = bk.Price;
            booksTable.Rows.Add(row);
            booksTable.AcceptChanges();
        }

        public void DeleteBook(int id)
        {
            foreach (DataRow row in booksTable.Rows)
            {
                if(row[0].ToString()==id.ToString())
                {
                    row.Delete();
                    break;
                }
            }
        }
        public DataTable FindBooks(string title)
        {
            DataTable copy = booksTable.Copy()
;            foreach (DataRow row in copy.Rows)
            {
                if (!row[1].ToString().Contains(title))
                {
                    row.Delete();
                }

            }
            return copy;
        }

        public void UpadateBook(Book bk)
        {
            foreach (DataRow row in booksTable.Rows)
            {
                if(row[0].ToString()==bk.BookId.ToString())
                {
                    row[1] = bk.Title;
                    row[2] = bk.Author;
                    row[3] = bk.Price;
                    booksTable.AcceptChanges();
                }
            }
        }
    }
    #endregion
    #region UILayer
    class OOPSAssignement
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
                //
                //var obj = AddNewBookDetails();
                //
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
            book.Title = HelperClass.GetString("Enter Book Title");
            book.Author = HelperClass.GetString("Enter Author Name");
            book.Price = HelperClass.GetNumber("Enter Price");
            app.UpadateBook(book);
        }

        private static void FindingBookDetails()
        {
            Book obj = new Book();
            string value = HelperClass.GetString("Find The Book");
            var data=app.FindBooks(value);
            Console.WriteLine(data.ToString());
        }
    }
    #endregion
}
