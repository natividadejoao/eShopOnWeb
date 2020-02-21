using System.Collections.Generic;
using Web.Dto;
using MediatR;
using Application.Entities.Catalogs;


namespace Web.Query.RequestsCatalogItem


{
    public class OrderBySomething : IRequest<IEnumerable<CatalogItemDto>>
    {
        public OrderBySomething(CatalogItem items, object criterio)
        {
            this.items = items;
            this.criterio = criterio;
        }

        public CatalogItem items{get;set;}
        public object criterio{get;set;}
    }
}