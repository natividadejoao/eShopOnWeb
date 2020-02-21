using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Entities.Catalogs;

namespace Application.Adapters
{
    public interface IAsyncCatalogItemReposiotry
    {
        Task<IEnumerable<CatalogItem>> ReadAll(Expression<Func<CatalogItem,bool>> predicate = null );
       
        Task<CatalogItem> Create (CatalogItem entity);

        Task<IEnumerable<CatalogItem>> CreateMany (IEnumerable<CatalogItem> entity);
        
        Task Delete(CatalogItem entity);
        Task UpdateById(CatalogItem entity,uint id);

        Task Update(CatalogItem entity);
        Task DeleteById(CatalogItem entity,uint id);

        IEnumerable<CatalogItem> OrderByCriterio(CatalogItem entity, object y);

        Task<int> Count(CatalogItem entity);



    }
}