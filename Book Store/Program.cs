using System;
using System.Collections.Generic;

namespace Book_Store
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BookManipulation bookManipulation = new BookManipulation();
            List<BookDetail> books = bookManipulation.AddBookDetails();
            foreach (var Book in books)
            {
                Console.WriteLine(Book.BookId + "-" + Book.Title + "-" + Book.Author + "-" + Book.ReleasedYear);
            }
            Console.ReadLine();
        }
    }
}
