using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class TownHouse : Residential
    {
        private int numberOfFloors;

        public TownHouse(int id, Address address, LegalForm legalform, int numberOfRooms, int numberOfFloors) 
            : base (id, address, legalform, numberOfRooms)
        {
            this.numberOfFloors = numberOfFloors;

        }

        public int NumberOfFloors {
            get { return numberOfFloors; }
            set { numberOfFloors = value; }
        }

        //ToDO implementera denna metod här!
        public override int Price { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }
    }
}