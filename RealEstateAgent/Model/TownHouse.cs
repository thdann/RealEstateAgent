using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealEstateAgent
{
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

        //Property - get/set for private instancevariables (encapsulation)
        public int NumberOfFloors {
            get { return numberOfFloors; }
            set { numberOfFloors = value; }
        }

        //Abstract method inhereted from base class and implemented here
        public override void ResidentialAbstractMedthod(int var2)
        {
            this.NumberOfFloors = var2;
        }
    }
}