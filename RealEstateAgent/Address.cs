using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Address
    {
        private String street;
        private String zipCode;
        private String city;
        private Countries country;

        public Address(String street, String zipCode, String city, Countries country)
        {
            this.street = street;
            this.zipCode = zipCode;
            this.city = city;
            this.country = country;
        }
    }


}