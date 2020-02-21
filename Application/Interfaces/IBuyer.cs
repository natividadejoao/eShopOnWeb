using System.Collections.Generic;
namespace Application.Interfaces
{
    public interface IBuyer
    {
        uint id{get;set;}
        IEnumerable<IBasket> baskets{get;}
        IEnumerable<IOrder> orders{get;}
    }
}