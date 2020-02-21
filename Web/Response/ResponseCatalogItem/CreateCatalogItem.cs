using System.Collections.Generic;
using Application.Entities.Catalogs;
using MediatR;
using Web.Dto;

namespace Web.Response.ResponseCatalogItem
{
    public class CreateCatalogItem : IRequest<IEnumerable<CatalogItemDto>>
    {
        public CreateCatalogItem(CatalogItem catalog)
        {
            this.catalog = catalog;
        }

        public CatalogItem catalog{get;set;}
    }
}