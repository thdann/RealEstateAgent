using System;


namespace RealEstateAgent
{
    [Serializable]
    public class TownHouse : Residential
    {
        // Instancevaiables specific to all ToenHouse estates
        private int numberOfFloors;

        //Constructors
        public TownHouse() { }
        public TownHouse(int id, Address address, LegalForm legalForm, int price, int numberOfRooms, int numberOfFloors) 
            : base (id, address, legalForm, price, numberOfRooms) 
        {
            this.numberOfFloors = numberOfFloors;
        
        }

        //Properties - get/set for private instancevariables (encapsulation)
        public int NumberOfFloors
        {
            get { return numberOfFloors; }
            set { numberOfFloors = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"{numberOfFloors}";
        }

    }
}