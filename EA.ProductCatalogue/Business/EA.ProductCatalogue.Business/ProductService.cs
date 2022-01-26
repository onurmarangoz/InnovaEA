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

namespace EA.ProductCatalogue.Business
{
    public class ProductService : IProductService
    {
        private IProductRepository repository;

        //Bu "servis" (hizmet) size ürün getirir. Üzümünü yiyin bağını sormayın!
        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IList<ProductListResponse>> GetProducts()
        {
            IList<Product> products = await repository.GetAll();
            
            
            return products.ConvertToResponseDto();
        }
    }
}
