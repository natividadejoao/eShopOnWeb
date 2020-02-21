using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Adapters.Repositories;
using Application.Entities.Baskets;

namespace Infras.Data.Repositories
{
    public class ProBasketRepo : IAsyncProBasketRepository
    {
          protected readonly EcommerceCommandContext command;
        protected readonly EcommerceQueryContext query;

        public ProBasketRepo(EcommerceCommandContext command, EcommerceQueryContext query)
        {
            this.command = command;
            this.query = query;
        }

        public async Task<int> Count(ProBasket entity)
        {
                var read = await ReadAll(entity => true);
            return read.Count();
        }

        public  async Task<ProBasket> Create(ProBasket entity)
        {
            await command.proBaskets.AddAsync(entity);
            await command.SaveChangesAsync();
            return entity;
        }

        public  async  Task<IEnumerable<ProBasket>> CreateMany(IEnumerable<ProBasket> entity)
        {
             await command.proBaskets.AddRangeAsync(entity);
            await command.SaveChangesAsync();
            return entity;
        }

        public  async Task Delete(ProBasket entity)
        {
            command.proBaskets.Remove(entity);
            await command.SaveChangesAsync(); 
        }

        public  async Task DeleteById(ProBasket entity, uint id)
        {
             command.proBaskets.Attach(entity);
            command.Remove(id);
            await command.SaveChangesAsync();  
        }

        public IEnumerable<ProBasket> OrderByCriterio(ProBasket entity, object y)
        {
             return command.proBaskets.OrderBy(x => entity.GetType().GetProperties() == y);
        }

        public Task<IEnumerable<ProBasket>> ReadAll(Expression<Func<ProBasket, bool>> predicate = null)
        => Task.Run(() => query.proBaskets.Where(predicate).AsEnumerable());

        public  async Task Update(ProBasket entity)
        {
            command.proBaskets.Update(entity);
            await command.SaveChangesAsync();
        }

        public  async Task UpdateById(ProBasket entity, uint id)
        {
            command.proBaskets.Attach(entity);
            command.Update(id);
            await command.SaveChangesAsync();
        }
    }
}