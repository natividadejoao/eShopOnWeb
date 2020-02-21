using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Entities.Orders;

namespace Application.Adapters.Repositories
{
    public interface IAsyncOrderRepository
    {
        Task<IEnumerable<Order>> ReadAll(Expression<Func<Order,bool>> predicate = null );
       
        Task<Order> Create (Order entity);

        Task<IEnumerable<Order>> CreateMany (IEnumerable<Order> entity);
        
        Task Delete(Order entity);
        Task UpdateById(Order entity,uint id);

        Task Update(Order entity);
        Task DeleteById(Order entity,uint id);

        IEnumerable<Order> OrderByCriterio(Order entity, object y);

        Task<int> Count(Order entity);
    }
}