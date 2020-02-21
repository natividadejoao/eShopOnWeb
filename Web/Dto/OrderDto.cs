using System.Collections.Generic;
using Application.Entities.Orders;
using Application.Interfaces;
using Application.ValueObjects;

namespace Web.Dto
{
    public class OrderDto
    {
         public OrderDto(Order order){
             this.address = order.address;
            this.status = order.status;
            this.total = order.total;
            this.id = order.id;
            this.baskets = order.baskets;
        }

        public uint id{ get ; }
        public Address address { get ;  }
        public OrderStatus status{get;}
        public List<IBasket> baskets {get;}
        public int total{get;}

    }
}