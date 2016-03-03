using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfSite.Models
{
    public class BooksFactory
    {
        public static IEnumerable<Book> CreateBooks()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book() { Author = "М. А. Булгаков", Name = "Мастер и Маргарита", Year = "1929-1940 года", Genre = "роман", MyOpinion = "Увлекательная и интереснейшая история о чертовщине в Москве." });
            books.Add(new Book() { Author = "И. С. Тургенев", Name = "Отцы и дети", Year = "1860—1861 года", Genre = "роман", MyOpinion = "Хорошо переданное разногласие поколений, нигилистический настрой; отлично раскрытый главный герой." });
            books.Add(new Book() { Author = "Джордж Оруэлл", Name = "1984", Year = "1948 год", Genre = "роман-антиутопия", MyOpinion = "Довольно хорошая пропаганда антипропаганды Советского Союза времен Холодной Войны." });
            return books;
        }  
    }
}