using MediatR;
using System.Collections.Generic;
using Web.Dto;

namespace Web.Query.RequestsWhilistBasket
{
    public class GetWhilistBaskets : IRequest<IEnumerable<WhilistBasketDto>>
    {
        public GetWhilistBaskets(string username)
        {
            this.username = username;
        }

        public string username{get;}

        
    }
}