using System.Collections.Generic;
using Application.Entities.Orders;
using MediatR;
using Web.Dto;

namespace  Web.Response.ResponseOrder
{

    public class CreateOrder : IRequest<IEnumerable<OrderDto>>
    {
        public CreateOrder(Order catalog)
        {
            this.catalog = catalog;
        }

        public Order catalog{get;set;}
    }
}