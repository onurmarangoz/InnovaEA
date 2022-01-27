using EA.ProductCatalogue.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spesifications
{
    public abstract class SpesificationBase<T> : ISpesification<T> where T : IEntity, new()
    {
        public IList<string> Errors { get; set; }

        public abstract bool IsSatisfy(T entity);
      

        public void Notify()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Errors.ToList().ForEach(error => stringBuilder.AppendLine(error));
            throw new Exception(stringBuilder.ToString());

        }
    }
}
