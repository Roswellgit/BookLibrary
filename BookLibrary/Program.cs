using System;
using System.Security.Cryptography.X509Certificates;

namespace BookLibrary
{
   class Program
    {
        static void Main(string[] args)
        {
            Library MBB = new Library();
            MBB.name = "My recommended books..";

            Book top1Book = new Book();
            top1Book.title = "The Alchemist";
            top1Book.author = "Paulo Coelho";
            top1Book.publisher = "?????";
            top1Book.releaseDate = new DateTime(1988, 1, 1);
            top1Book.ISBN = "BOOK12123123";

            Book top2Book = new Book
            {
                title = "Don Quixote",
                author = "Miguel de Cervantes",
                publisher = "??????",
                releaseDate = new DateTime(1605, 1, 1),
                ISBN = "BOOK45464546"
            };

            MBB.AddBook(top1Book);
            MBB.AddBook(top2Book);

            MBB.SearchBook("Cervantes");
            MBB.DisplayBookInfo(top1Book);
        }
    }

}
