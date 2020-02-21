using System.Collections.Generic;
using Web.Dto;
using MediatR;
using Application.Entities.Baskets;

namespace Web.Query.RequestsBasket

{
    public class CountBasket : IRequest<IEnumerable<BasketDto>>
    {
        public CountBasket(Basket catalog)
        {
            this.catalog = catalog;
        }

        public Basket catalog { get;set;}
        
    }
}