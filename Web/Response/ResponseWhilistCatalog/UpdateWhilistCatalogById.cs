using System.Collections.Generic;
using Application.Entities.Catalogs;
using Application.Entities.Whilists;
using MediatR;
using Web.Dto;

namespace Web.Response.ResponseWhilistCatalog
{
    public class UpdateWhilistCatalogById : IRequest<IEnumerable<WhilistCatalogDto>>
    {
        public UpdateWhilistCatalogById(uint id, WhilistCatalog item)
        {
            this.id = id;
            this.item = item;
        }

        public uint id{get;set;}
        public WhilistCatalog item{get;set;}
    }
}