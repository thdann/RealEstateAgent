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

        public override int Attribute2
        {
            get { return numberOfFloors; }
            set { numberOfFloors = value; }
        }

    }
}