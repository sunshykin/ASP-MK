using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Library.Models;
using Library.Content.Base;

namespace Library.Content
{
    namespace Base
    {
        public static class Open
        {
            public static LibraryContext db = new LibraryContext(); //Задаем БД в 1 месте, чтобы не создавать новые классы == терять список книг во время работы сервера без перезапуска
        }
    }

    public class Check
    {
        public static bool BookGot(int BookId, int UserId)
        {
            BookModel CurrentUser = Library.Content.Base.Open.db.Users.Find(UserId).Books.FirstOrDefault(x => x.Id == BookId);
            if (CurrentUser != null && CurrentUser.Id == BookId)
                return true;
            return false;
        }
    }
    public class Global
    {
        public static int UserId = 0, AdminId = -1; //0 и -1, чтобы при пустой БД юзер не имел прав админа(только админайди все равно где-то обнуляется при старте сервера =( )
        private static UserModel Admin = new UserModel {FirstName = "Дмитрий", Surname = "Федосов", Email = "bossmen5@mail.ru", Nick = "SunshY", Pass = "4300"};
        public static void CheckAdmin() //Проверяет есть ли строка с данными админа в БД и находит его айди
        {
            if (!Open.db.Users.Any())
            {
                Open.db.Users.Add(Admin);
                AdminId = Open.db.Users.Count();
            }
            else
            {
                foreach (var user in Open.db.Users)
                {
                    if (user.Email == Admin.Email && user.Nick == Admin.Nick && user.Pass == Admin.Pass)
                    {
                        AdminId = user.Id;
                        break;
                    }
                }
                if (AdminId == 0)
                {
                    Open.db.Users.Add(Admin);
                    AdminId = Open.db.Users.Count();
                }
            }
            Open.db.SaveChanges();
        }

        public static void BooksGot() //Чтобы после рестарта сервера вносить данные о выданных книгах в ЮзерМодели
        {
            UserModel CurrentUser;
            foreach (UserModel user in Open.db.Users.Include(x => x.Books))
            {
                //CurrentUser = Open.db.Users.Find(user.Id);
                CurrentUser = user;
                Open.db.Entry(CurrentUser).State = EntityState.Modified;
            }
            Open.db.SaveChanges();
        }
    }
}