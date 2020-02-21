using System.Collections.Generic;
using Web.Dto;
using MediatR;
using Application.Entities.Catalogs;


namespace Web.Query.RequestsCatalogItem
{
    public class CountCatalogItem : IRequest<IEnumerable<CatalogItemDto>>
    {
        public CountCatalogItem(CatalogItem catalog)
        {
            this.catalog = catalog;
        }

        public CatalogItem catalog { get;set;}
        
    }
}