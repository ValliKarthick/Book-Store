

using System;
using System.Collections.Generic;

namespace Book_Store
{
    public class BookManipulation
    {
        public List<BookDetail> AddBookDetails()
        {
            var BookIdNumber = 1;
            List<BookDetail> bookDetails = new List<BookDetail>();
            for (int NumberOfBooks=1; NumberOfBooks <=3; NumberOfBooks++)
            {
                Console.WriteLine("Enter Book Title to be added");
                string bookTitleFromUser = Console.ReadLine();

                Console.WriteLine("Enter the Author of the book");
                string bookAuthorFromUser = Console.ReadLine();

                Console.WriteLine("Enter the Released Year of the book");
                int releasedYearFromUser = Convert.ToInt32(Console.ReadLine());
              
                bookDetails.Add(new BookDetail()
                {
                    BookId = BookIdNumber,
                    Title = bookTitleFromUser,
                    Author = bookAuthorFromUser,
                    ReleasedYear = releasedYearFromUser
                });
                BookIdNumber++;
            }
            return bookDetails;
        }
    }
}
