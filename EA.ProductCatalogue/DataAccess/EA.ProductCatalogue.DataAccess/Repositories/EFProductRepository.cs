using EA.ProductCatalogue.DataAccess.DataContext;
using EA.ProductCatalogue.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EA.ProductCatalogue.DataAccess.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private EADbContext context;

      
        public EFProductRepository(EADbContext context)
        {
            this.context = context;
         
        }
        public async Task<int> Add(Product entity)
        {
            await context.Products.AddAsync(entity);
            return await context.SaveChangesAsync();

        }

        public Task<int> Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Product>> GetAll()
        {
            var products = await context.Products.ToListAsync();
            return products;
        }

        public async Task<Product> GetById(int id)
        {
            return await context.Products.FindAsync(id);
        }

        public Task<IList<Product>> GetWithCriteria(Expression<Func<bool, Product>> criteria)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> SearchProductsByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
