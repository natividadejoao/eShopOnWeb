using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Entities.Baskets;


namespace Application.Adapters.Repositories
{
    public interface IAsyncBasketRepository
    {
        Task<IEnumerable<Basket>> ReadAll(Expression<Func<Basket,bool>> predicate = null );
       
        Task<Basket> Create (Basket entity);

        Task<IEnumerable<Basket>> CreateMany (IEnumerable<Basket> entity);
        
        Task Delete(Basket entity);
        Task UpdateById(Basket entity,uint id);

        Task Update(Basket entity);
        Task DeleteById(Basket entity,uint id);

        IEnumerable<Basket> OrderByCriterio(Basket entity, object y);

        Task<int> Count(Basket entity);
    }
}