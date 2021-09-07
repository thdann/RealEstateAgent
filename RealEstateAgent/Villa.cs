using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Villa : Residential
    {
        private int gardenArea;

        public Villa (int id, Address address, int numberOfRooms, int gardenArea) 
            : base (id, address, numberOfRooms) 
        {
            this.gardenArea = gardenArea;
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