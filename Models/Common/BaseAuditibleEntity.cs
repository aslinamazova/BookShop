using System;
namespace BookShop.Models.Common
{
    public class BaseAuditibleEntity : BaseEntity
    {
        public DateTime CreadetAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}

