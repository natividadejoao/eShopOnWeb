using System.Collections.Generic;
using Application.Entities.Baskets;
using Application.Interfaces;

namespace Web.Dto
{
    public class BasketDto
    {
        public BasketDto(Basket basket){
             this.id = basket.id;
            this.basketItems = basket.basketItems;
        }

        public uint id { get ;}

        public IEnumerable<ICatalogItem> basketItems {get;}
       
    }
}