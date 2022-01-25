using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.ProductCatalogue.Entities
{
   public class Product : EntityBase
    {
        [Required(ErrorMessage = "Ürün adı boş olamaz")]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int? StockCount { get; set; }
        public string Description { get; set; }
        public float? Discount { get; set; }

        public string Comments { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
