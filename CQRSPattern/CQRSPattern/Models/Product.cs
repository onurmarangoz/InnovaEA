using System;
using System.Collections.Generic;

#nullable disable

namespace CQRSPattern.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? StockCount { get; set; }
        public string Description { get; set; }
        public float? Discount { get; set; }
        public string Comments { get; set; }
        public int? CategoryId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdateOn { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Category Category { get; set; }
    }
}
