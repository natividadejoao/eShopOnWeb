using MediatR;
using System.Collections.Generic;
using Web.Dto;

namespace Web.Query.RequestsBasket
{
    public class GetBasket : IRequest<IEnumerable<BasketDto>>
    {
        public GetBasket(string username)
        {
            this.username = username;
        }

        public string username{get;}

        
    }
}