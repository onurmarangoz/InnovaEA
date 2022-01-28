using CQRSPattern.CQRS.Queries;
using CQRSPattern.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.Handlers
{
    public class GetAllProductsQueryHandler
    {
        private readonly InnovaEADbContext dbContext;

        public GetAllProductsQueryHandler(InnovaEADbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<GetAllProductsQueryResponse> GetAllProduct(GetAllProductsQueryRequest request)
        {
            return dbContext.Products.Select(x => new GetAllProductsQueryResponse { Id = x.Id, Description = x.Description, Name = x.Name, Price = x.Price, StockCount = x.StockCount })
                .ToList();
        }
    }
}
