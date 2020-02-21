using Web.Dto;
using System.Collections.Generic;
using MediatR;
using Application.Entities.Catalogs;
using Application.Entities.Baskets;

namespace Web.Response.ResponseBasket
{
    public class DeleteBasketById : IRequest<IEnumerable<BasketDto>>
    {
        public DeleteBasketById(Basket catalog, uint id)
        {
            this.catalog = catalog;
            this.id = id;
        }

        public Basket catalog{get;}
        public uint id{get;}
    }
}