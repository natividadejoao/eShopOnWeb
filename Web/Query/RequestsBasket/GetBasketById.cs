using MediatR;
using System.Collections.Generic;
using Web.Dto;
namespace Web.Query.RequestsBasket
{
    public class GetBasketById : IRequest<IEnumerable<BasketDto>>
    {
        public GetBasketById(string username, uint id)
        {
            this.username = username;
            this.id = id;
        }

        public string username{get;}
        public uint id{get;}
    }
}