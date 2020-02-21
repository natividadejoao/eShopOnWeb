using MediatR;
using System.Collections.Generic;
using Web.Dto;

namespace Web.Query.RequestsCatalogItem
{
    public class GetCatalogItemById : IRequest<IEnumerable<CatalogItemDto>>
    {
        public GetCatalogItemById(string username, uint id)
        {
            this.username = username;
            this.id = id;
        }

        public string username{get;}
        public uint id{get;}
    }
}