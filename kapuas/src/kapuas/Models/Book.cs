using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kapuas.Models
{
    public class Book
    {
        public string isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
    }
}
