using System.Collections.Generic;
using Application.Entities.Whilists;
using Application.Interfaces;

namespace Web.Dto
{
    public class WhilistBasketDto
    {
         public WhilistBasketDto(WhilistBasket basket){
             this.id = basket.id;
            this.baskets = basket.baskets;
        }

         public uint id { get ;  }

        public IEnumerable<IBasket> baskets {get;}

    }
}