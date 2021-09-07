using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class TownHouse : Residential
    {
        private int numberOfFloors;

        public TownHouse (int id, Address address, int numberOfRooms, int numberOfFloors) 
            : base (id, address, numberOfRooms)
        {
            this.numberOfFloors = numberOfFloors;

        }

        public override int NumberOfRooms { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }
        public override int Id { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }
        public override Address Address { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }
        public override LegalForm LegalForm { 
            get => throw new NotImplementedException(); s
            set => throw new NotImplementedException(); }
    }
}