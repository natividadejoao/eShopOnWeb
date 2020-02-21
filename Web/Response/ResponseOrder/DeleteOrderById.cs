using Web.Dto;
using System.Collections.Generic;
using MediatR;
using Application.Entities.Orders;

namespace  Web.Response.ResponseOrder
{

    public class DeleteOrderById : IRequest<IEnumerable<OrderDto>>
    {
        public DeleteOrderById(Order catalog, uint id)
        {
            this.catalog = catalog;
            this.id = id;
        }

        public Order catalog{get;}
        public uint id{get;}
    }
}