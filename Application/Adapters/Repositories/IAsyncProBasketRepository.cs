using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Entities.Baskets;

namespace Application.Adapters.Repositories
{
    public interface IAsyncProBasketRepository
    {
          Task<IEnumerable<ProBasket>> ReadAll(Expression<Func<ProBasket,bool>> predicate = null );
       
        Task<ProBasket> Create (ProBasket entity);

        Task<IEnumerable<ProBasket>> CreateMany (IEnumerable<ProBasket> entity);
        
        Task Delete(ProBasket entity);
        Task UpdateById(ProBasket entity,uint id);

        Task Update(ProBasket entity);
        Task DeleteById(ProBasket entity,uint id);

        IEnumerable<ProBasket> OrderByCriterio(ProBasket entity, object y);

        Task<int> Count(ProBasket entity);
    }
}