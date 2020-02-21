using Web.Dto;
using System.Collections.Generic;
using MediatR;
using Application.Entities.Catalogs;

namespace Web.Response.ResponseCatalogItem
{
    public class CreateManyCatalogItem : IRequest<IEnumerable<CatalogItemDto>>
    {
        public CreateManyCatalogItem(IEnumerable<CatalogItem> items)
        {
            this.items = items;
        }

        public IEnumerable<CatalogItem> items {get;set;}

    }
}