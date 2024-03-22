using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Library
    {
        public string name;
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void SearchBook(string author)
        {
            foreach (var book in books)
            {
                if (book.author.Contains(author))
                {
                    Console.WriteLine("BOOK FOUND...");
                    DisplayBookInfo(book);
                }
            }
        }
        public void DisplayBookInfo(Book book)
        {
            Console.WriteLine("Book Information in " + name + "...");
            Console.WriteLine("Title: " + book.title);
            Console.WriteLine("Author: " + book.author);
            Console.WriteLine("Publisher: " + book.publisher);
            Console.WriteLine("Release Date: " + book.releaseDate);
            Console.WriteLine("ISBN: " + book.ISBN);
            Console.WriteLine("---------------------");
        }
        public void DeleteBook(Book book)
        {
            books.Remove(book);
        }
    }
}
