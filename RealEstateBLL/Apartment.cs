using System;



namespace RealEstateAgent
{
    [Serializable]
    public class Apartment : Residential
    {
        // Instancevaiables specific to all Apartment estates
        private int floor;

        //Constructors
        public Apartment() { }

        public Apartment(int id, Address address, LegalForm legalForm, int price, int numberOfRooms, int floor ) 
            : base(id, address, legalForm, price, numberOfRooms) 
        {
            this.floor = floor;  
           
        }

        //Properties - get/set for private instancevariables (encapsulation)
        public int Floor 
        {
            get { return floor; }
            set { floor = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"{floor}";
        }

    }

 }