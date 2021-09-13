using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Residential : Estate
    {

        public Residential()
        {

        }

        private int numberOfRooms;
        //public Residential(int id, Address address, LegalForm legalform, int numberOfRooms) 
        //    : base(id, address, legalform)
        //{
        //    this.numberOfRooms = numberOfRooms; 
        //}
        public int NumberOfRooms {
            get { return numberOfRooms; }
            set { numberOfRooms = value; }
        }
    }

}