using System.Collections.Generic;
using Application.Entities.Baskets;
using Application.Entities.Catalogs;
using MediatR;
using Web.Dto;

namespace Web.Response.ResponseBasket
{
    public class UpdateBasketById : IRequest<IEnumerable<BasketDto>>
    {
        public UpdateBasketById(uint id, Basket item)
        {
            this.id = id;
            this.item = item;
        }

        public uint id{get;set;}
        public Basket item{get;set;}
    }
}