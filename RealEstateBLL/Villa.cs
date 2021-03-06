using System;

namespace RealEstateAgent
{
    [Serializable]
    public class Villa : Residential
    {
       
        private int gardenArea;

        //Constructors
        public Villa() { }

        public Villa(int id, Address address, LegalForm legalForm, int price, int numberOfRooms, int gardenArea) 
            : base (id, address, legalForm, price, numberOfRooms) 
        {
            this.gardenArea = gardenArea;
        }

        //Properties - get/set for private instancevariables (encapsulation)
        public int GardenArea
        {
            get { return gardenArea; }
            set { gardenArea = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"{gardenArea}";
        }

    }
}