using System.Collections.Generic;


namespace Application.Interfaces
{
    public interface IWhilist
    {
        uint id{get;set;}
         IEnumerable<IBasket> baskets{get;}
         IEnumerable<ICatalogItem> items{get;}
         int idBuyer{get;}
    }
}