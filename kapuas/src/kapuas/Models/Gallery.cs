using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kapuas.Models
{
    public class Gallery
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
