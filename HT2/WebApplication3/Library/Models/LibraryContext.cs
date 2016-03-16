using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class LibraryContext : DbContext
    {
        /*public ApplicationDbContext():base("DefaultConnection")
        { }*/
        public DbSet<BookModel> Books { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}