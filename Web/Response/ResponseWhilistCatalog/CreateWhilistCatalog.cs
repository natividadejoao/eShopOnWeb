using System.Collections.Generic;
using Application.Entities.Catalogs;
using Application.Entities.Whilists;
using MediatR;
using Web.Dto;

namespace Web.Response.ResponseWhilistCatalog
{
    public class CreateWhilistCatalog : IRequest<IEnumerable<WhilistCatalogDto>>
    {
        public CreateWhilistCatalog(WhilistCatalog catalog)
        {
            this.catalog = catalog;
        }

        public WhilistCatalog catalog{get;set;}
    }
}