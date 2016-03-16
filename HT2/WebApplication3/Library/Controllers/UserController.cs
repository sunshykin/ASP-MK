using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;
using Library.Content.Base;

namespace Library.Controllers
{
    
    public class UserController : Controller
    {
        int AuthenticationCheck(string Nickname, string Password)
        {
            foreach (var user in Open.db.Users)
            {
                if (Nickname == user.Nick && Password == user.Pass)
                {
                    return user.Id;
                }
            }
            return 0;
        }
        // GET: User
        public ActionResult page()
        {
            return View(Open.db.Users.ToList());
        }

        public ActionResult personal()
        {
            if (Library.Content.Global.UserId != 0)
            {
                return View();
            }
            return HttpNotFound();
        }

        public ActionResult register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult register([Bind(Include = "Id,FirstName,Surname,Email,Nick,Pass")] UserModel AddedUser)
        {
            if (ModelState.IsValid)
            {
                if (AuthenticationCheck(AddedUser.Nick, AddedUser.Pass) != 0) return HttpNotFound();
                Open.db.Users.Add(AddedUser);
                Open.db.SaveChanges();
                Library.Content.Global.UserId = AuthenticationCheck(AddedUser.Nick, AddedUser.Pass);
                return RedirectToAction("personal");
            }
            return View(AddedUser);
        }

        [HttpGet]
        public ActionResult enter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult enter([Bind(Include = "Id,Nick,Pass")] UserModel EnteredUser)
        {
            if (EnteredUser != null)
            {
                if (AuthenticationCheck(EnteredUser.Nick, EnteredUser.Pass) != 0)
                {
                    Library.Content.Global.UserId = AuthenticationCheck(EnteredUser.Nick, EnteredUser.Pass);
                    return RedirectToAction("personal");
                }
                return View(EnteredUser);
            }
            return HttpNotFound();
        }

    }
}