using System.Collections.Generic;
using Web.Dto;
using MediatR;
using Application.Entities.Orders;

namespace Web.Query.RequestsOrder
{
    public class OrderBySomething : IRequest<IEnumerable<OrderDto>>
    {
        public OrderBySomething(Order items, object criterio)
        {
            this.items = items;
            this.criterio = criterio;
        }

        public Order items{get;set;}
        public object criterio{get;set;}
    }
}