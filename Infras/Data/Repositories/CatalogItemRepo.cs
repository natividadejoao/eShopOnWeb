using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Adapters;
using Application.Entities.Catalogs;
using System.Linq;
using System.Collections.Generic;

namespace Infras.Data.Repositories
{
    public class CatalogItemRepo : IAsyncCatalogItemReposiotry
    {
        protected readonly EcommerceCommandContext command;
        protected readonly EcommerceQueryContext query;

        public CatalogItemRepo(EcommerceCommandContext command, EcommerceQueryContext query)
        {
            this.command = command;
            this.query = query;
        }

    
        public Task<IEnumerable<CatalogItem>> ReadAll(Expression<Func<CatalogItem, bool>> predicate = null)
        => Task.Run(() => query.catalogItems.Where(predicate).AsEnumerable());
        
    
        public async Task<CatalogItem> Create(CatalogItem entity){
            await command.catalogItems.AddAsync(entity);
            await command.SaveChangesAsync();
            return entity;
        }
       
        public async Task Delete(CatalogItem entity){
            command.catalogItems.Remove(entity);
            await command.SaveChangesAsync();      
        }
       

        public async Task DeleteById(CatalogItem entity,uint id) {
            command.catalogItems.Attach(entity);
            command.Remove(id);
            await command.SaveChangesAsync();            
        }

        

        public async Task UpdateById(CatalogItem entity,uint id)
        {
            command.catalogItems.Attach(entity);
            command.Update(id);
            await command.SaveChangesAsync();
        }

        public async Task Update(CatalogItem entity)
        {
            command.catalogItems.Update(entity);
            await command.SaveChangesAsync();

        }
        public IEnumerable<CatalogItem> OrderByCriterio(CatalogItem entity, object y){
           return command.catalogItems.OrderBy(x => entity.GetType().GetProperties() == y);
            
        }

    

        public async Task<int> Count(CatalogItem entity) {
            var read = await ReadAll(entity => true);
            return read.Count();
            
        }

        public async Task<IEnumerable<CatalogItem>> CreateMany(IEnumerable<CatalogItem> entity)
        {
             await command.catalogItems.AddRangeAsync(entity);
            await command.SaveChangesAsync();
            return entity;
        }

       
    }
}