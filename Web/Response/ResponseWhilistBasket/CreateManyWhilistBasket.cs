using Web.Dto;
using System.Collections.Generic;
using MediatR;
using Application.Entities.Catalogs;
using Application.Entities.Whilists;

namespace Web.Response.ResponseWhilistBasket
{
    public class CreateManyWhilistBasket : IRequest<IEnumerable<WhilistBasketDto>>
    {
        public CreateManyWhilistBasket(IEnumerable<WhilistBasket> items)
        {
            this.items = items;
        }

        public IEnumerable<WhilistBasket> items {get;set;}

    }
}