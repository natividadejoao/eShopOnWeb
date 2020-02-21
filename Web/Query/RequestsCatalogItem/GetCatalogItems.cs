using MediatR;
using System.Collections.Generic;
using Web.Dto;

namespace Web.Query.RequestsCatalogItem
{
    public class GetCatalogItems : IRequest<IEnumerable<CatalogItemDto>>
    {
        public GetCatalogItems(string username)
        {
            this.username = username;
        }

        public string username{get;}

        
    }
}