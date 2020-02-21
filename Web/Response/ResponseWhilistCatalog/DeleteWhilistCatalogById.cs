using Web.Dto;
using System.Collections.Generic;
using MediatR;
using Application.Entities.Catalogs;
using Application.Entities.Whilists;

namespace Web.Response.ResponseWhilistCatalog
{
    public class DeleteWhilistCatalogById : IRequest<IEnumerable<WhilistCatalogDto>>
    {
        public DeleteWhilistCatalogById(WhilistCatalog catalog, uint id)
        {
            this.catalog = catalog;
            this.id = id;
        }

        public WhilistCatalog catalog{get;}
        public uint id{get;}
    }
}