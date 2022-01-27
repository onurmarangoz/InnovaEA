using EA.ProductCatalogue.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spesifications
{
   public interface ISpesification<T> where T: IEntity,new()
    {
        /// <summary>
        /// T entity'si için uygulayacağınız kural.
        /// </summary>
        /// <param name="entity">Kuralın hangi TEntity instance'i için kullanılacağı</param>
        /// <returns></returns>
        bool IsSatisfy(T entity);
        /// <summary>
        /// Hata oluştuğunda tüm uygulamadan erişilebilecek bir uyarı sistemi....
        /// </summary>
        void Notify();
    }
}
