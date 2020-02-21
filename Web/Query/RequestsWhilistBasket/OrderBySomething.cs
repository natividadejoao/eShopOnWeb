using System.Collections.Generic;
using Web.Dto;
using MediatR;

using Application.Entities.Whilists;

namespace Web.Query.RequestsWhilistBasket
{
    public class OrderBySomething : IRequest<IEnumerable<WhilistBasketDto>>
    {
        public OrderBySomething(WhilistBasket items, object criterio)
        {
            this.items = items;
            this.criterio = criterio;
        }

        public WhilistBasket items{get;set;}
        public object criterio{get;set;}
    }
}