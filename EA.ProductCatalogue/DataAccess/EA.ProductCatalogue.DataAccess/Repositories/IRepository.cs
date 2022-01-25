using EA.ProductCatalogue.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EA.ProductCatalogue.DataAccess.Repositories
{
   public interface IRepository<TEntity> where TEntity:IEntity,new()
    {
        Task<IList<TEntity>> GetAll();
        Task<int> Add(TEntity entity);
        Task<int> Update(TEntity entity);
        Task<int> Delete(TEntity entity);
        Task<TEntity> GetById(int id);

        Task<IList<TEntity>> GetWithCriteria(Expression<Func<bool, TEntity>> criteria);

    }
}
