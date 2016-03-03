using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfSite.Models
{
    public class Book
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string MyOpinion { get; set; }
    }
}