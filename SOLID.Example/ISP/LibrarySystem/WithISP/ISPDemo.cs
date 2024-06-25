using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Example.ISP.LibrarySystem.WithISP
{
    public class Book
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public override string ToString()
        {
            return $"[BookId: {BookId}, Title: {Title}, Author:{Author}, ISBN:{ISBN}]";
        }
    }
    public interface IBorrowReturn
    {
        void BorrowBook(string bookId);
        void ReturnBook(string bookId);
    }
    public interface ISearchable
    {
        void SearchCatalog(string searchTerm);
    }
    public interface IManageInventory
    {
        void AddBook(Book book);
        void RemoveBook(string bookId);
    }
    public class Member : IBorrowReturn, ISearchable
    {
        public void BorrowBook(string bookId)
        {
            // Implementation to borrow a book.
            Console.WriteLine($"Member Borrow Book, BookId: {bookId}");
        }
        public void ReturnBook(string bookId)
        {
            // Implementation to return a book.
            Console.WriteLine($"Member Return Book, BookId: {bookId}");
        }
        public void SearchCatalog(string searchTerm)
        {
            // Implementation to search books.
            Console.WriteLine($"Member Search Book, Search Catalog: {searchTerm}");
        }
    }
    public class Librarian : IBorrowReturn, ISearchable, IManageInventory
    {
        public void BorrowBook(string bookId)
        {
            // Implementation to borrow a book.
            Console.WriteLine($"Librarian Borrow Book, BookId: {bookId}");
        }
        public void ReturnBook(string bookId)
        {
            // Implementation to return a book.
            Console.WriteLine($"Librarian Return Book, BookId: {bookId}");
        }
        public void SearchCatalog(string searchTerm)
        {
            // Implementation to search books.
            Console.WriteLine($"Librarian Search Book, Search Catalog: {searchTerm}");
        }
        public void AddBook(Book book)
        {
            // Implementation to add a book.
            Console.WriteLine($"Librarian Add Book, {book}");
        }
        public void RemoveBook(string bookId)
        {
            // Implementation to remove a book.
            Console.WriteLine($"Librarian Remove Book, BookId: {bookId}");
        }
    }
    public class Guest : ISearchable
    {
        public void SearchCatalog(string searchTerm)
        {
            // Implementation to search books.
            Console.WriteLine($"Guest Search Book, Search Catalog: {searchTerm}");
        }
    }
}
