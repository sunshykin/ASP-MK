using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Nick { get; set; }
        public string Pass { get; set; }
        
        public ICollection<BookModel> Books { get; set; }
        public UserModel()
        {
            Books = new List<BookModel>();
        } 
    }
}