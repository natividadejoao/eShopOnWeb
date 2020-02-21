using Web.Dto;
using System.Collections.Generic;
using MediatR;
using Application.Entities.Catalogs;

namespace Web.Response.ResponseCatalogItem
{
    public class DeleteCatalogItemById : IRequest<IEnumerable<CatalogItemDto>>
    {
        public DeleteCatalogItemById(CatalogItem catalog, uint id)
        {
            this.catalog = catalog;
            this.id = id;
        }

        public CatalogItem catalog{get;}
        public uint id{get;}
    }
}