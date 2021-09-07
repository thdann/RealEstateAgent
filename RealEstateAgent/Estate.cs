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

        public Estate(int id, Address address) 
        {
            this.id = id;
            this.address = address;
        }

        public abstract int Id { get; set; }
        public abstract Address Address { get; set; }
        public abstract LegalForm LegalForm { get; set; }

        public Address Address1
        {
            get => default;
            set
            {
            }
        }

        public LegalForm LegalForm1
        {
            get => default;
            set
            {
            }
        }
    }
}