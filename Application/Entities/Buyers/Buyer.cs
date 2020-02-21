using System.Collections.Generic;
using Application.Interfaces;

namespace Application.Entities.Buyers
{
    public class Buyer : IBuyer
    {     public static uint Seed = 0;
        public uint id { get ; set ; }

        public IEnumerable<IBasket> baskets {get;}

        public IEnumerable<IOrder> orders {get;}

        public IEnumerable<IWhilist> whilist {get;}

        public Buyer(){
            id = ++Seed;
        }
    }
}