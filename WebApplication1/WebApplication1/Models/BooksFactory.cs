using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BooksFactory
    {
        public static IEnumerable<Book> CreateBooks()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book() { Author = "Ar", Description = "R2", Name = "D2" });
            books.Add(new Book() { Author = "Aa", Description = "Ara", Name = "D2aa" });
            return books;
        }  
    }
}