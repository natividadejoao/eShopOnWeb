using Web.Dto;
using System.Collections.Generic;
using MediatR;
using Application.Entities.Catalogs;
using Application.Entities.Whilists;

namespace Web.Response.ResponseWhilistBasket
{
    public class DeleteWhilistBasketById : IRequest<IEnumerable<WhilistBasketDto>>
    {
        public DeleteWhilistBasketById(WhilistBasket catalog, uint id)
        {
            this.catalog = catalog;
            this.id = id;
        }

        public WhilistBasket catalog{get;}
        public uint id{get;}
    }
}