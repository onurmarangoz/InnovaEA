using EA.ProductCatalogue.Business.DTO.Responses;
using EA.ProductCatalogue.DataAccess.Repositories;
using EA.ProductCatalogue.Entities;
using System;
using System.Collections.Generic;
using EA.ProductCatalogue.Business.Extensions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using EA.ProductCatalogue.Business.DTO.Requests;
using AutoMapper;

namespace EA.ProductCatalogue.Business
{
    public class ProductService : IProductService
    {
        private IProductRepository repository;
        private IMapper mapper;

        //Bu "servis" (hizmet) size ürün getirir. Üzümünü yiyin bağını sormayın!
        public ProductService(IProductRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<Product> AddProduct(AddProductRequest product)
        {

            if (product == null)
            {
                throw new ArgumentNullException("product");
            }

            var entity = product.ConvertToEntity(mapper);
            await repository.Add(entity);
            return entity;
        }

        public async Task Delete(int id)
        {
           await  repository.Delete(id);

        }

        public async Task<ProductListResponse> GetProductById(int id)
        {
            Product product = await repository.GetById(id);
            return product.ConvertToResponseDto(mapper);
        }

        public async Task<IList<ProductListResponse>> GetProducts()
        {
            IList<Product> products = await repository.GetAll();


            return products.ConvertToResponseDto(mapper);
        }

        public async Task<bool> ProductIsExist(int id)
        {
            return await repository.IsEntityExist(id);
        }

        public async Task<Product> UpdateProduct(UpdateProductRequest updateProductRequest)
        {
            var productEntity = updateProductRequest.ConvertToEntity(mapper);
            var affectedRow = await repository.Update(productEntity);

            return affectedRow > 0 ? productEntity : null;
        }
    }
}
