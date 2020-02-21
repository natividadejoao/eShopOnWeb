using MediatR;
using System.Collections.Generic;
using Web.Dto;

namespace Web.Query.RequestsProBasket
{
    public class GetProBasket : IRequest<IEnumerable<ProBasketDto>>
    {
        public GetProBasket(string username)
        {
            this.username = username;
        }

        public string username{get;}

        
    }
}