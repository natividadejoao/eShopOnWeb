using MediatR;
using System.Collections.Generic;
using Web.Dto;
namespace Web.Query.RequestsWhilistBasket
{
    public class GetWhilistBasketById : IRequest<IEnumerable<WhilistBasketDto>>
    {
        public GetWhilistBasketById(string username, uint id)
        {
            this.username = username;
            this.id = id;
        }

        public string username{get;}
        public uint id{get;}
    }
}