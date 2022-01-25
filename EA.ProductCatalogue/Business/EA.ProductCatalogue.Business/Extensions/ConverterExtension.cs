using EA.ProductCatalogue.Business.DTO.Responses;
using EA.ProductCatalogue.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.ProductCatalogue.Business.Extensions
{
    public static class ConverterExtension
    {
        public static IList<ProductListResponse> ConvertToResponseDto(this IList<Product> products)
        {
            List<ProductListResponse> responses = new List<ProductListResponse>();
            products.ToList().ForEach(entity => responses.Add(new ProductListResponse
            {
                Description = entity.Description,
                Discount = entity.Discount,
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price
            }));

            return responses;

        }
    }
}
