using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IBasket
    {
        uint id {get;set;}
       IEnumerable<ICatalogItem> basketItems {get;}
        int idBuyer{get;}
    }
}