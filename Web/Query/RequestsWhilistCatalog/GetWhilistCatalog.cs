using MediatR;
using System.Collections.Generic;
using Web.Dto;

namespace Web.Query.RequestsWhilistCatalog
{
    public class GetWhilistCatalog: IRequest<IEnumerable<WhilistCatalogDto>>
    {
        public GetWhilistCatalog(string username)
        {
            this.username = username;
        }

        public string username{get;}

        
    }
}