using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooklyProject.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        //yazar birden fazla kitapa sahip olucak
        public virtual List<Book> Books { get; set; }
    }
}