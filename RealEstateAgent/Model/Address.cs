using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    // A model class that represent the address
    public class Address
    {
        //Instancevariables specific to all Address objects
        private String street;
        private String zipCode;
        private String city;
        private Countries country;

        //Default constructor
        public Address() { }

        //Constructor with parameters
        public Address(String street, String zipCode, String city, Countries country)
        {
            this.street = street;
            this.zipCode = zipCode;
            this.city = city;
            this.country = country;
        }

        //Properties - get/set for private instancevariables (encapsulation)
        public String Street {
            get { return street; }
            set { street = value; }
        }
        public String ZipCode {
            get { return zipCode; }
            set { zipCode = value; } 
        }
        public String City {
            get { return city; }
            set { city = value; }
        }
        public Countries Country {
            get { return country; }
            set { country = value; }
        }

        //String formatted to one line
        public override string ToString()
        {
            string strAddress = string.Format("{0}, {1}, {2}, {3}", street, zipCode, city, country);
            return strAddress;

        }
    }


}