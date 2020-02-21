using MediatR;
using System.Collections.Generic;
using Web.Dto;

namespace Web.Query.RequestsOrder
{
    public class GetOrders : IRequest<IEnumerable<OrderDto>>
    {
        public GetOrders(string username)
        {
            this.username = username;
        }

        public string username{get;}

        
    }
}