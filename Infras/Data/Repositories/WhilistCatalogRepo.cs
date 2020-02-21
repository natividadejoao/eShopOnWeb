using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Adapters.Repositories;
using Application.Entities.Whilists;

namespace Infras.Data.Repositories
{
    /*public class WhilistCatalogRepo /*: IAsyncWhilistCatalogRepository
    {
        protected readonly EcommerceCommandContext command;
        protected readonly EcommerceQueryContext query;

        public WhilistCatalogRepo(EcommerceCommandContext command, EcommerceQueryContext query)
        {
            this.command = command;
            this.query = query;
        }

         public async Task<int> Count(WhilistCatalog entity)
        {
                var read = await ReadAll(entity => true);
            return read.Count();
        }

        public  async Task<WhilistCatalog> Create(WhilistCatalog entity)
        {
            await command.whilistCatalogs.AddAsync(entity);
            await command.SaveChangesAsync();
            return entity;
        }

        public  async  Task<IEnumerable<WhilistCatalog>> CreateMany(IEnumerable<WhilistCatalog> entity)
        {
             await command.whilistCatalogs.AddRangeAsync(entity);
            await command.SaveChangesAsync();
            return entity;
        }

        public  async Task Delete(WhilistCatalog entity)
        {
            command.whilistCatalogs.Remove(entity);
            await command.SaveChangesAsync(); 
        }

        public  async Task DeleteById(WhilistCatalog entity, uint id)
        {
             command.whilistCatalogs.Attach(entity);
            command.Remove(id);
            await command.SaveChangesAsync();  
        }

        public IEnumerable<WhilistCatalog> OrderByCriterio(WhilistCatalog entity, object y)
        {
             return command.whilistCatalogs.OrderBy(x => entity.GetType().GetProperties() == y);
        }

        public Task<IEnumerable<WhilistCatalog>> ReadAll(Expression<Func<WhilistCatalog, bool>> predicate = null)
        => Task.Run(() => query.whilistCatalogs.Where(predicate).AsEnumerable());

        public  async Task Update(WhilistCatalog entity)
        {
            command.whilistCatalogs.Update(entity);
            await command.SaveChangesAsync();
        }

        public  async Task UpdateById(WhilistCatalog entity, uint id)
        {
            command.whilistCatalogs.Attach(entity);
            command.Update(id);
            await command.SaveChangesAsync();
        }
    }*/
}