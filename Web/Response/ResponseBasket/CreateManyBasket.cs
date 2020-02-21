using Web.Dto;
using System.Collections.Generic;
using MediatR;
using Application.Entities.Catalogs;
using Application.Entities.Baskets;

namespace Web.Response.ResponseBasket
{
    public class CreateManyBasket: IRequest<IEnumerable<BasketDto>>
    {
        public CreateManyBasket(IEnumerable<Basket> items)
        {
            this.items = items;
        }

        public IEnumerable<Basket> items {get;set;}

    }
}