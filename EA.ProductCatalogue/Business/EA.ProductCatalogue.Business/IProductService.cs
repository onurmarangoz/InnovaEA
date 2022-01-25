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
    }
}
