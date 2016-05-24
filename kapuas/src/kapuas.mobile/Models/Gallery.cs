using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kapuas.mobile.Models
{
    public class Gallery
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories {
            get { return (from c in Books where c.Category != null select c.Category).Distinct(); }
        }
    }
}
