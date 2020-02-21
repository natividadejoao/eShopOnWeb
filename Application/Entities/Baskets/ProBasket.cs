using System.Collections.Generic;
using Application.Interfaces;

namespace Application.Entities.Baskets
{
    public class ProBasket : IBasket
    {   
        public static uint Seed = 0;

        public ProBasket()
        {
            id = ++Seed;
           
        }

        public uint id { get ; set ; }

        public IEnumerable<ICatalogItem> basketItems {get;}

        public int idBuyer {get;}
    }
}