using EA.ProductCatalogue.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spesifications
{
    public class AddProductRequestSpesification : SpesificationBase<Product>
    {
        public override bool IsSatisfy(Product entity)
        {
            if (string.IsNullOrEmpty(entity.Name))
            {
                this.Errors.Add("Ürün adı boş olamaz");
            }

            if (entity.Price < 0)
            {
                this.Errors.Add("Ürün adı negatif olamaz");
            }

            if (Errors.Count > 0)
            {
                Notify();
                return false;
            }

            return true;

        }
    }
}
