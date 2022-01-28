using System;
using System.Collections.Generic;

#nullable disable

namespace CQRSPattern.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdateOn { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
