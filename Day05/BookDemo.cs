using System;
namespace Day01.Day05
{
    class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public int BookPrice { get; set; }
    }

    class program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            //Console.WriteLine("Enter BookId  : ");
            //book.BookId = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Book Title  : ");
            //book.BookTitle = Console.ReadLine();
            //Console.WriteLine("Enter Book Author : ");
            //book.BookAuthor = Console.ReadLine();
            //Console.WriteLine("Enter Book Price  : ");
            //book.BookPrice = int.Parse(Console.ReadLine());
            Helper();

            Console.WriteLine($"Book Title is {book.BookTitle} Author is {book.BookAuthor} the Book Id {book.BookId} Price Is {book.BookPrice}");
            Console.WriteLine("===============================");


            Book[] array = new Book[5];
            for (int i = 0; i < 5; i++)
            {
                Book book1 = Helper();
                array[i] = book1;
            }
    
            foreach (var item in array)
            {
                Console.WriteLine($"Book Title is {item.BookTitle} Author is {item.BookAuthor} the Book Id {item.BookId} Price Is {item.BookPrice}");
                Console.WriteLine("=============================");
            }
            
            Console.ReadLine();
        }

        public static Book Helper()
        {
            Book book = new Book();
            Console.WriteLine("Enter BookId  : ");
            book.BookId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Book Title  : ");
            book.BookTitle = Console.ReadLine();
            Console.WriteLine("Enter Book Author : ");
            book.BookAuthor = Console.ReadLine();
            Console.WriteLine("Enter Book Price  : ");
            book.BookPrice = int.Parse(Console.ReadLine());
            return book;
        }
    }
}