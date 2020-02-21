using System.Collections.Generic;
using Application.Entities.Whilists;
using Application.Interfaces;

namespace Web.Dto
{
    public class WhilistCatalogDto
    {
        public WhilistCatalogDto(WhilistCatalog catalog){
           this.id = catalog.id;
            this.items = catalog.items;
        }

         public uint id { get ;  }

        public IEnumerable<ICatalogItem> items {get;}
    }
}