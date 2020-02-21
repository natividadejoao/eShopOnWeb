using System.Collections.Generic;
using Application.Entities.Baskets;
using Application.Entities.Catalogs;
using MediatR;
using Web.Dto;

namespace Web.Response.ResponseProBasket
{
    public class UpdateProBasketById : IRequest<IEnumerable<ProBasketDto>>
    {
        public UpdateProBasketById(uint id, ProBasket item)
        {
            this.id = id;
            this.item = item;
        }

        public uint id{get;set;}
        public ProBasket item{get;set;}
    }
}