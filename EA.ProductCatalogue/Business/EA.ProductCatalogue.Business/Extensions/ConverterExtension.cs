using AutoMapper;
using EA.ProductCatalogue.Business.DTO.Requests;
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
        public static IList<ProductListResponse> ConvertToResponseDto(this IList<Product> products, IMapper mapper)
        {
            //List<ProductListResponse> responses = new List<ProductListResponse>();
            //products.ToList().ForEach(entity => responses.Add(new ProductListResponse
            //{
            //    Description = entity.Description,
            //    Discount = entity.Discount,
            //    Id = entity.Id,
            //    Name = entity.Name,
            //    Price = entity.Price
            //}));
            List<ProductListResponse> responses = mapper.Map<List<ProductListResponse>>(products);
            return responses;

        }

        public static Product ConvertToEntity(this AddProductRequest addProductRequest, IMapper mapper)
        {
            var entity = mapper.Map<Product>(addProductRequest);
            return entity;
        }

        public static ProductListResponse ConvertToResponseDto(this Product product, IMapper mapper)
        {
            return mapper.Map<ProductListResponse>(product);
        }


    }
}
