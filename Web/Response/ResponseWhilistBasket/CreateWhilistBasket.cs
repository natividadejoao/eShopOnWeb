using System.Collections.Generic;
using Application.Entities.Catalogs;
using Application.Entities.Whilists;
using MediatR;
using Web.Dto;

namespace Web.Response.ResponseWhilistBasket
{
    public class CreateWhilistBasket : IRequest<IEnumerable<WhilistBasketDto>>
    {
        public CreateWhilistBasket(WhilistBasket catalog)
        {
            this.catalog = catalog;
        }

        public WhilistBasket catalog{get;set;}
    }
}