using System;


namespace RealEstateAgent
{
    [Serializable]
    public class Warehouse : Commercial
    {
        // Instancevaiables specific to all Warehouse estates
        private int numberOfShelves;

        //Constructors
        public Warehouse() { }

        public Warehouse(int id, Address address, LegalForm legalForm, int price, int squareMeters, int numberofShelves) 
            : base(id, address, legalForm, price, squareMeters)
        {
            this.numberOfShelves = numberofShelves;        
        }

        //Properties - get/set for private instancevariables (encapsulation)
        public int NumberOfShelves
        {
            get { return numberOfShelves; }
            set { numberOfShelves = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"{numberOfShelves}";
        }

    }
}