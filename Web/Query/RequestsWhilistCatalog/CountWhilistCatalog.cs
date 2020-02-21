using System.Collections.Generic;
using Web.Dto;
using MediatR;

using Application.Entities.Whilists;

namespace Web.Query.RequestsWhilistCatalog
{
    public class CountWhilistCatalog : IRequest<IEnumerable<WhilistCatalogDto>>
    {
        public CountWhilistCatalog(WhilistCatalog catalog)
        {
            this.catalog = catalog;
        }

        public WhilistCatalog catalog { get;set;}
        
    }
}