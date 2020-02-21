using System.Collections.Generic;
using Application.ValueObjects;

namespace Application.Interfaces
{
    public interface IOrder
    {
          uint id{get;set;}
         Address address{get;set;}

         int total {get;}
         int idBuyer{get;}
    }
}