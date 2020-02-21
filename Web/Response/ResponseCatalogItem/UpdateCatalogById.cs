using System.Collections.Generic;
using Application.Entities.Catalogs;
using MediatR;
using Web.Dto;

namespace Web.Response.ResponseCatalogItem
{
    public class UpdateCatalogById : IRequest<IEnumerable<CatalogItemDto>>
    {
        public UpdateCatalogById(uint id, CatalogItem item)
        {
            this.id = id;
            this.item = item;
        }

        public uint id{get;set;}
        public CatalogItem item{get;set;}
    }
}