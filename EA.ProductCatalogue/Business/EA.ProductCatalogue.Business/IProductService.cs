using EA.ProductCatalogue.Business.DTO.Requests;
using EA.ProductCatalogue.Business.DTO.Responses;
using EA.ProductCatalogue.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.ProductCatalogue.Business
{
   public interface IProductService
    {
        Task<IList<ProductListResponse>> GetProducts();
        Task<Product> AddProduct(AddProductRequest product);
        Task<ProductListResponse> GetProductById(int id);
        Task<Product> UpdateProduct(UpdateProductRequest updateProductRequest);
        Task<bool> ProductIsExist(int id);
        Task Delete(int id);
    }
}
