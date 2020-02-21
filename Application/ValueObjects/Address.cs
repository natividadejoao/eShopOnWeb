using System;

namespace Application.ValueObjects
{
    public class Address
    {
        private Address()
        {
        }

        public Address(string zipCode, string street, string state, string country, string city)
        {
            this.zipCode = zipCode;
            this.street = street;
            this.state = state;
            this.country = country;
            this.city = city;
        }


        public string zipCode{get;}
        public string street{get;}

        public string state{get;}
        public string country{get;}
        public string city{get;}
        
        
    }
}