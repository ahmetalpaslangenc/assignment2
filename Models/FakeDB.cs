using System;
using System.Collections.Generic;
using System.Linq;

namespace CetBooks.Models
{
    public class FakeDB
    {
        public static List<Book> Db { get; set; } = new List<Book>();

        static FakeDB() 
        {
            Db.Add(
                new Book 
                {
                    Id = 1,
                    Title = "C#",
                    Description = "Programming Languages",
                    Author = "Ahmet Yıldırım",
                    PageSize = 200,
                    Price = 100,
                    PublishDate = DateTime.Now
                }
            );
            Db.Add(
                new Book
                {
                    Id = 2,
                    Title = "Asp.net",
                    Description = "Programming Languages",
                    Author = "Ahmet Yıldırım",
                    PageSize = 300,
                    Price = 150,
                    PublishDate = DateTime.Now
                }
            );
        }

        public List<Book> GetAllBooks()
        {
            return Db;
        }

        public Book? GetBookById(int id)
        {
            return Db.FirstOrDefault(b => b.Id == id);
        }

        public bool DeleteBook(int id)
        {
            var book = GetBookById(id);
            if (book == null) return false;
            Db.Remove(book);
            return true;
        }

        public void AddBook(Book book)
        {
            book.Id = Db.Any() ? Db.Max(b => b.Id) + 1 : 1;
            Db.Add(book);
        }
    }
}


