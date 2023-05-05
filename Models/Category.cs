using System;
using BookShop.Models.Common;

namespace BookShop.Models
{
    public class Category : BaseAuditibleEntity
    {
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}

