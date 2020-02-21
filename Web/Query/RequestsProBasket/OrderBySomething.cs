using System.Collections.Generic;
using Web.Dto;
using MediatR;

using Application.Entities.Baskets;

namespace Web.Query.RequestsProBasket
{
    public class OrderBySomething : IRequest<IEnumerable<ProBasketDto>>
    {
        public OrderBySomething(ProBasket items, object criterio)
        {
            this.items = items;
            this.criterio = criterio;
        }

        public ProBasket items{get;set;}
        public object criterio{get;set;}
    }
}