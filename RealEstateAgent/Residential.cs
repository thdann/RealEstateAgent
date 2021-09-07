using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Residential : Estate
    {

        private int numberOfRooms;
        public Residential(int id, Address address, int numberOfRooms) : base(id, address)
        {
            this.numberOfRooms = numberOfRooms; 
        }
        public abstract int NumberOfRooms { get; set; }
    }

}