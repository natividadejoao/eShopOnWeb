using System.Collections.Generic;
using Application.Interfaces;

namespace Application.Entities.Whilists
{
    public class WhilistBasket : IWhilist
    {
        public static uint Seed = 0;

        public WhilistBasket(IEnumerable<IBasket> baskets, int idBuyer)
        {
            id = ++Seed;
            this.baskets = baskets;
            this.idBuyer = idBuyer;
        }

        private WhilistBasket(){}

        public uint id { get ; set ; }

        public IEnumerable<IBasket> baskets {get;}

        public IEnumerable<ICatalogItem> items => throw new System.NotImplementedException();

        public int idBuyer {get;}
    }
}