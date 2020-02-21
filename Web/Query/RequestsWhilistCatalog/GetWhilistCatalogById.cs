using MediatR;
using System.Collections.Generic;
using Web.Dto;
namespace Web.Query.RequestsWhilistCatalog
{
    public class GetWhilistCatalogById : IRequest<IEnumerable<WhilistCatalogDto>>
    {
        public GetWhilistCatalogById(string username, uint id)
        {
            this.username = username;
            this.id = id;
        }

        public string username{get;}
        public uint id{get;}
    }
}