﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooklyProject.Entities
{
    public class Book

    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string CoverImageUrl { get; set; }
        public decimal Price { get; set; }
        public int DiscountRate { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual List<BookCategory> BookCategories { get; set; }
        public int Review {  get; set; }
        public bool IsOnSale { get; set; }
    }
}