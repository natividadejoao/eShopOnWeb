using System.Collections.Generic;
using Web.Dto;
using MediatR;
using Application.Entities.Baskets;

namespace Web.Query.RequestsProBasket
{
    public class CountProBasket : IRequest<IEnumerable<ProBasketDto>>
    {
        public CountProBasket(ProBasket catalog)
        {
            this.catalog = catalog;
        }

        public ProBasket catalog { get;set;}
        
    }
}