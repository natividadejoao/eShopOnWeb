using System.Collections.Generic;
using Application.Interfaces;

namespace Application.Entities.Whilists
{
    public class WhilistCatalog : IWhilist
    {   public static uint Seed = 0;

        public WhilistCatalog(IEnumerable<ICatalogItem> items, int idBuyer)
        {
            id = ++Seed;
            this.items = items;
            this.idBuyer = idBuyer;
        }

        private WhilistCatalog(){}

        public uint id { get ; set ; }

        public IEnumerable<IBasket> baskets => throw new System.NotImplementedException();

        public IEnumerable<ICatalogItem> items {get;}

        public int idBuyer {get;}
    }
}