using Web.Dto;
using System.Collections.Generic;
using MediatR;
using Application.Entities.Catalogs;
using Application.Entities.Whilists;

namespace Web.Response.ResponseWhilistCatalog
{
    public class CreateManyWhilistCatalog : IRequest<IEnumerable<WhilistCatalogDto>>
    {
        public CreateManyWhilistCatalog(IEnumerable<WhilistCatalog> items)
        {
            this.items = items;
        }

        public IEnumerable<WhilistCatalog> items {get;set;}

    }
}