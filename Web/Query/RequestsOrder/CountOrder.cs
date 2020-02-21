using System.Collections.Generic;
using Web.Dto;
using MediatR;

using Application.Entities.Orders;

namespace Web.Query.RequestsOrder
{
    public class CountOrder : IRequest<IEnumerable<OrderDto>>
    {
        public CountOrder(Order catalog)
        {
            this.catalog = catalog;
        }

        public Order catalog { get;set;}
        
    }
}