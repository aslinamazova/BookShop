using System;
using BookShop.Models.Common;

namespace BookShop.Models
{
    public class Book : BaseAuditibleEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public double Quantity { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
    }
}

