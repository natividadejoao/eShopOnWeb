using System.Collections.Generic;
using Application.Entities.Orders;
using MediatR;
using Web.Dto;

namespace  Web.Response.ResponseOrder
{

    public class UpdateOrderById : IRequest<IEnumerable<OrderDto>>
    {
        public UpdateOrderById(uint id, Order item)
        {
            this.id = id;
            this.item = item;
        }

        public uint id{get;set;}
        public Order item{get;set;}
    }
}