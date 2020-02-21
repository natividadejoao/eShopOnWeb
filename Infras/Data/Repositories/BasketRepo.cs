using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Adapters.Repositories;
using Application.Entities.Baskets;

namespace Infras.Data.Repositories
{
    public class BasketRepo : IAsyncBasketRepository
    {
          protected readonly EcommerceCommandContext command;
        protected readonly EcommerceQueryContext query;

        public BasketRepo(EcommerceCommandContext command, EcommerceQueryContext query)
        {
            this.command = command;
            this.query = query;
        }

        public async Task<int> Count(Basket entity)
        {
                var read = await ReadAll(entity => true);
            return read.Count();
        }

        public  async Task<Basket> Create(Basket entity)
        {
            await command.baskets.AddAsync(entity);
            await command.SaveChangesAsync();
            return entity;
        }

        public  async  Task<IEnumerable<Basket>> CreateMany(IEnumerable<Basket> entity)
        {
             await command.baskets.AddRangeAsync(entity);
            await command.SaveChangesAsync();
            return entity;
        }

        public  async Task Delete(Basket entity)
        {
            command.baskets.Remove(entity);
            await command.SaveChangesAsync(); 
        }

        public  async Task DeleteById(Basket entity, uint id)
        {
             command.baskets.Attach(entity);
            command.Remove(id);
            await command.SaveChangesAsync();  
        }

        public IEnumerable<Basket> OrderByCriterio(Basket entity, object y)
        {
             return command.baskets.OrderBy(x => entity.GetType().GetProperties() == y);
        }

        public Task<IEnumerable<Basket>> ReadAll(Expression<Func<Basket, bool>> predicate = null)
        => Task.Run(() => query.baskets.Where(predicate).AsEnumerable());

        public  async Task Update(Basket entity)
        {
            command.baskets.Update(entity);
            await command.SaveChangesAsync();
        }

        public  async Task UpdateById(Basket entity, uint id)
        {
            command.baskets.Attach(entity);
            command.Update(id);
            await command.SaveChangesAsync();
        }
    }
}