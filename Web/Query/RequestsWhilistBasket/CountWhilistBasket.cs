using System.Collections.Generic;
using Web.Dto;
using MediatR;
using Application.Entities.Whilists;

namespace Web.Query.RequestsWhilistBasket
{
    public class CountWhilistBasket : IRequest<IEnumerable<WhilistBasketDto>>
    {
        public CountWhilistBasket(WhilistBasket catalog)
        {
            this.catalog = catalog;
        }

        public WhilistBasket catalog { get;set;}
        
    }
}