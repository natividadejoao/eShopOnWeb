using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Adapters.Repositories;
using Application.Entities.Whilists;

namespace Infras.Data.Repositories
{
    public class WhilistBasketRepo //:  IAsyncWhilistBasketRepository
    {   
        /* protected readonly EcommerceCommandContext command;
        protected readonly EcommerceQueryContext query;

        public WhilistBasketRepo(EcommerceCommandContext command, EcommerceQueryContext query)
        {
            this.command = command;
            this.query = query;
        }

        public async Task<int> Count(WhilistBasket entity)
        {
                var read = await ReadAll(entity => true);
            return read.Count();
        }

        public  async Task<WhilistBasket> Create(WhilistBasket entity)
        {
            await command.whilistBasket.AddAsync(entity);
            await command.SaveChangesAsync();
            return entity;
        }

        public  async  Task<IEnumerable<WhilistBasket>> CreateMany(IEnumerable<WhilistBasket> entity)
        {
             await command.whilistBasket.AddRangeAsync(entity);
            await command.SaveChangesAsync();
            return entity;
        }

        public  async Task Delete(WhilistBasket entity)
        {
            command.whilistBasket.Remove(entity);
            await command.SaveChangesAsync(); 
        }

        public  async Task DeleteById(WhilistBasket entity, uint id)
        {
             command.whilistBasket.Attach(entity);
            command.Remove(id);
            await command.SaveChangesAsync();  
        }

        public IEnumerable<WhilistBasket> OrderByCriterio(WhilistBasket entity, object y)
        {
             return command.whilistBasket.OrderBy(x => entity.GetType().GetProperties() == y);
        }

        public Task<IEnumerable<WhilistBasket>> ReadAll(Expression<Func<WhilistBasket, bool>> predicate = null)
        => Task.Run(() => query.whilistBasket.Where(predicate).AsEnumerable());

        public  async Task Update(WhilistBasket entity)
        {
            command.whilistBasket.Update(entity);
            await command.SaveChangesAsync();
        }

        public  async Task UpdateById(WhilistBasket entity, uint id)
        {
            command.whilistBasket.Attach(entity);
            command.Update(id);
            await command.SaveChangesAsync();
        } */
    }
}