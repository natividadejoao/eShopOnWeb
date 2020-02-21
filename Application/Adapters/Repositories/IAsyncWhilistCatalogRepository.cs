using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Entities.Whilists;

namespace Application.Adapters.Repositories
{
    public interface IAsyncWhilistCatalogRepository
    {
        
        Task<IEnumerable<WhilistCatalog>> ReadAll(Expression<Func<WhilistCatalog,bool>> predicate = null );
       
        Task<WhilistCatalog> Create (WhilistCatalog entity);

        Task<IEnumerable<WhilistCatalog>> CreateMany (IEnumerable<WhilistCatalog> entity);
        
        Task Delete(WhilistCatalog entity);
        Task UpdateById(WhilistCatalog entity,uint id);

        Task Update(WhilistCatalog entity);
        Task DeleteById(WhilistCatalog entity,uint id);

        IEnumerable<WhilistCatalog> OrderByCriterio(WhilistCatalog entity, object y);

        Task<int> Count(WhilistCatalog entity);
    }
}