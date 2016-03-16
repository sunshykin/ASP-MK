using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;
using Library.Content.Base;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        //LibraryContext db = new LibraryContext();

        public ActionResult Index()
        {
            return View(Open.db.Books.ToList());
        }
        // GET: Home/Create
        public ActionResult Create()
        {
            if (Library.Content.Global.UserId != 0 && Library.Content.Global.UserId == Library.Content.Global.AdminId)
            {
                return View();
            }
            return HttpNotFound();
        }

        // POST: Home/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Author,Title,Amount")] BookModel AddedBook)
        {
            if (ModelState.IsValid)
            {
                bool inStock = false;
                foreach (var book in Open.db.Books)
                {
                    if (AddedBook.Author == book.Author && AddedBook.Title == book.Title)
                    {
                        book.Amount += AddedBook.Amount;
                        inStock = true;
                    }  
                }
                if (!inStock) Open.db.Books.Add(AddedBook);
                Open.db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(AddedBook);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (Library.Content.Global.UserId == Library.Content.Global.AdminId)
            {
                BookModel bookModel = Open.db.Books.Find(id);
                Open.db.Books.Remove(bookModel);
                Open.db.SaveChanges();
                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Take(int? id)
        {
            UserModel CurrentUser = Open.db.Users.Find(Library.Content.Global.UserId);
            BookModel CurrentBook = Open.db.Books.Find(id);
            if (CurrentBook.Amount > 0)
            {
                CurrentUser.Books.Add(CurrentBook);
                Open.db.Entry(CurrentUser).State = EntityState.Modified;
                Open.db.SaveChanges();
                CurrentBook.Amount--;
                Open.db.SaveChanges();
            }
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Return(int? id)
        {
            UserModel CurrentUser = Open.db.Users.Find(Library.Content.Global.UserId);
            BookModel CurrentBook = Open.db.Books.Find(id);
            if (CurrentBook.Amount > 0)
            {
                CurrentUser.Books.Remove(CurrentBook);
                Open.db.Entry(CurrentUser).State = EntityState.Modified;
                Open.db.SaveChanges();
                CurrentBook.Amount++;
                Open.db.SaveChanges();
            }
            return RedirectToAction("Index");

        }
    }
}