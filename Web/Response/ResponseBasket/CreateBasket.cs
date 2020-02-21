using System.Collections.Generic;
using Application.Entities.Baskets;
using MediatR;
using Web.Dto;

namespace Web.Response.ResponseBasket
{
    public class CreateBasket : IRequest<IEnumerable<BasketDto>>
    {
        public CreateBasket(Basket catalog)
        {
            this.catalog = catalog;
        }

        public Basket catalog{get;set;}
    }
}