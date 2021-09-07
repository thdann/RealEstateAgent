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

        public Estate(int id, Address adress) 
        {
            this.id = id;
            this.address = address;
        }

        public abstract int Id { get; set; }
        public abstract Address Address { get; set; }
    }
}