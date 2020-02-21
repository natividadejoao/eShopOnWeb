using System.Collections.Generic;
using Web.Dto;
using MediatR;
using Application.Entities.Baskets;


namespace Web.Query.RequestsBasket
{
    public class OrderBySomething : IRequest<IEnumerable<BasketDto>>
    {
        public OrderBySomething(Basket items, object criterio)
        {
            this.items = items;
            this.criterio = criterio;
        }

        public Basket items{get;set;}
        public object criterio{get;set;}
    }
}