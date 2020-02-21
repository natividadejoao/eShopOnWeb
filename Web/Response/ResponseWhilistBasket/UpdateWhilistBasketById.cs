using System.Collections.Generic;
using Application.Entities.Catalogs;
using Application.Entities.Whilists;
using MediatR;
using Web.Dto;

namespace Web.Response.ResponseWhilistBasket
{
    public class UpdateWhilistBasketById : IRequest<IEnumerable<WhilistBasketDto>>
    {
        public UpdateWhilistBasketById(uint id, WhilistBasket item)
        {
            this.id = id;
            this.item = item;
        }

        public uint id{get;set;}
        public WhilistBasket item{get;set;}
    }
}