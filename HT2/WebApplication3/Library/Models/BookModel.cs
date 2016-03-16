﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }

        public ICollection<UserModel> Users { get; set; }
        public BookModel()
        {
            Users = new List<UserModel>();
        }
    }
}