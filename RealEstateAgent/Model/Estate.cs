using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Estate : IEstate
    {
        private int id;
        private Address address;
        private LegalForm legalForm;
        private int price;

        public Estate()
        {

        }

        //public Estate(int id, Address address, LegalForm legalForm, int price)
        //{
        //    this.id = id;
        //    this.address = address;
        //    this.legalForm = legalForm;
        //    this.price = price;
        //}

        // Constructor to be used when price is yet not set
        //public Estate(int id, Address address, LegalForm legalForm) 
        //    : this(id, address, legalForm, 0) { }
        public int Id { 
            get { return id; }
            set { id = value; }
        }
        public Address Address {
            get { return address; }
            set { address = value; }
        }
        public LegalForm LegalForm {
            get { return legalForm; }
            set { legalForm = value; } 
        }   
        
        // Abstract method - price is determened on lower level
        public abstract int Price { get; set; }

    }
}