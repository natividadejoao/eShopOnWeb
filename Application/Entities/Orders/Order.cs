using System.Collections.Generic;
using Application.Interfaces;
using Application.ValueObjects;

namespace Application.Entities.Orders
{
    public class Order : IOrder
    {   
        public static uint Seed = 0;
        public uint id{ get ;set; }
        public Address address { get ; set; }
        public OrderStatus status{get;set;}
        public List<IBasket> baskets {get;}
        public int total{get;}

        public int idBuyer {get;}

        public Order(Address address, List<IBasket> baskets,OrderStatus status){
            this.address =address;
            this.baskets = baskets;
            this.status = status;
            id =++Seed;

        }

        private Order(){
            
        }

       
    }
}