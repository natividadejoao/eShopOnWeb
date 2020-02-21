using Web.Dto;
using System.Collections.Generic;
using MediatR;
using Application.Entities.Catalogs;
using Application.Entities.Orders;

namespace Web.Response.ResponseOrder
{
    public class CreateManyOrder : IRequest<IEnumerable<OrderDto>>
    {
        public CreateManyOrder(IEnumerable<Order> items)
        {
            this.items = items;
        }

        public IEnumerable<Order> items {get;set;}

    }
}