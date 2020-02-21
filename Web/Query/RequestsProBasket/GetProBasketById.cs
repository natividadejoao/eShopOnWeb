using MediatR;
using System.Collections.Generic;
using Web.Dto;
namespace Web.Query.RequestsProBasket
{
    public class GetProBasketById : IRequest<IEnumerable<ProBasketDto>>
    {
        public GetProBasketById(string username, uint id)
        {
            this.username = username;
            this.id = id;
        }

        public string username{get;}
        public uint id{get;}
    }
}