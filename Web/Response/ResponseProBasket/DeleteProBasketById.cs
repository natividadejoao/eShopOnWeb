using Web.Dto;
using System.Collections.Generic;
using MediatR;
using Application.Entities.Catalogs;
using Application.Entities.Baskets;

namespace Web.Response.ResponseProBasket
{
    public class DeleteProBasketById : IRequest<IEnumerable<ProBasketDto>>
    {
        public DeleteProBasketById(ProBasket catalog, uint id)
        {
            this.catalog = catalog;
            this.id = id;
        }

        public ProBasket catalog{get;}
        public uint id{get;}
    }
}