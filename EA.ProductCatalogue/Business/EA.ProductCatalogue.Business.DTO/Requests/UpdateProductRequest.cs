using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.ProductCatalogue.Business.DTO.Requests
{
   public class UpdateProductRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ürün adı boş olamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Ürün fiyatı boş olamaz")]

        public decimal Price { get; set; }
        public int? StockCount { get; set; }
        public string Description { get; set; }
        public float? Discount { get; set; }
        public int? CaregoryId { get; set; }
    }
}
