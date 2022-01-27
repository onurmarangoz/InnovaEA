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

        public async Task<int> Delete(Product entity)
        {
            context.Products.Remove(entity);
            return  await context.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            var product = await context.Products.FirstOrDefaultAsync(p => p.Id == id);
            await Delete(product);
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

        public async Task<bool> IsEntityExist(int id)
        {
            var isEntityExists = await context.Products.AnyAsync(x => x.Id == id);
            return isEntityExists;
        }

        public Task<IEnumerable<Product>> SearchProductsByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(Product entity)
        {
            
            context.Products.Update(entity);
            return await context.SaveChangesAsync();

        }
    }
}
