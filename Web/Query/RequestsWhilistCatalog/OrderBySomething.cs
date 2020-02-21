using System.Collections.Generic;
using Web.Dto;
using MediatR;
using Application.Entities.Whilists;

namespace Web.Query.RequestsWhilistCatalog
{
    public class OrderBySomething : IRequest<IEnumerable<WhilistCatalogDto>>
    {
        public OrderBySomething(WhilistCatalog items, object criterio)
        {
            this.items = items;
            this.criterio = criterio;
        }

        public WhilistCatalog items{get;set;}
        public object criterio{get;set;}
    }
}