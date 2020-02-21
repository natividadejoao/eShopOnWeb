using MediatR;
using System.Collections.Generic;
using Web.Dto;
namespace Web.Query.RequestsOrder
{
    public class GetOrderById : IRequest<IEnumerable<OrderDto>>
    {
        public GetOrderById(string username, uint id)
        {
            this.username = username;
            this.id = id;
        }

        public string username{get;}
        public uint id{get;}
    }
}