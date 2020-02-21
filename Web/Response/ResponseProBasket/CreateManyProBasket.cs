using Web.Dto;
using System.Collections.Generic;
using MediatR;
using Application.Entities.Catalogs;
using Application.Entities.Baskets;

namespace  Web.Response.ResponseProBasket

{
    public class CreateManyProBasket : IRequest<IEnumerable<ProBasketDto>>
    {
        public CreateManyProBasket(IEnumerable<ProBasket> items)
        {
            this.items = items;
        }

        public IEnumerable<ProBasket> items {get;set;}

    }
}