using System.Collections.Generic;
using Application.Interfaces;

namespace Application.Entities.Baskets
{
    public class Basket : IBasket
    {
        public static uint Seed = 0;

        public uint id { get ; set ;}

        public IEnumerable<ICatalogItem> basketItems {get;}

        public int idBuyer {get;}
        public Basket()
        {
            id = ++Seed;
           
        }
    }
}