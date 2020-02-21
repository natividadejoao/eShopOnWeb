using System.Collections.Generic;
using Application.Entities.Baskets;
using Application.Entities.Catalogs;
using MediatR;
using Web.Dto;

namespace Web.Response.ResponseProBasket
{
    public class CreateProBasket : IRequest<IEnumerable<ProBasketDto>>
    {
        public CreateProBasket(ProBasket catalog)
        {
            this.catalog = catalog;
        }

        public ProBasket catalog{get;set;}
    }
}