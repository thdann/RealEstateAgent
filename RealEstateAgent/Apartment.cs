using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Apartment : Residential
    {
        private bool hasElevator;

        public Apartment(int id, Address address, int numberOfRooms, bool hasElevator) : base(id, address, numberOfRooms) 
        {
            this.hasElevator = hasElevator;
        
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
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }
    }
}