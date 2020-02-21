using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Entities.Whilists;

namespace Application.Adapters.Repositories
{
    public interface IAsyncWhilistBasketRepository
    {
          Task<IEnumerable<WhilistBasket>> ReadAll(Expression<Func<WhilistBasket,bool>> predicate = null );
       
        Task<WhilistBasket> Create (WhilistBasket entity);

        Task<IEnumerable<WhilistBasket>> CreateMany (IEnumerable<WhilistBasket> entity);
        
        Task Delete(WhilistBasket entity);
        Task UpdateById(WhilistBasket entity,uint id);

        Task Update(WhilistBasket entity);
        Task DeleteById(WhilistBasket entity,uint id);

        IEnumerable<WhilistBasket> OrderByCriterio(WhilistBasket entity, object y);

        Task<int> Count(WhilistBasket entity);
    }
}