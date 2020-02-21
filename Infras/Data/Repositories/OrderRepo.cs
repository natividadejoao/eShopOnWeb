using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Adapters.Repositories;
using Application.Entities.Orders;

namespace Infras.Data.Repositories
{
    public class OrderRepo : IAsyncOrderRepository
    {
          protected readonly EcommerceCommandContext command;
        protected readonly EcommerceQueryContext query;

        public OrderRepo(EcommerceCommandContext command, EcommerceQueryContext query)
        {
            this.command = command;
            this.query = query;
        }

        public Task<int> Count(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<Order> Create(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> CreateMany(IEnumerable<Order> entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(Order entity, uint id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> OrderByCriterio(Order entity, object y)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> ReadAll(Expression<Func<Order, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task Update(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateById(Order entity, uint id)
        {
            throw new NotImplementedException();
        }
    }
}