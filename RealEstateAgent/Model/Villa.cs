using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealEstateAgent
{
    public class Villa : Residential
    {
        // Instancevaiables specific to all Villa estates
        private int gardenArea;

        //Constructors
        public Villa() { }
        public Villa(int id, Address address, LegalForm legalForm, int price, int numberOfRooms, int gardenArea) 
            : base (id, address, legalForm, price, numberOfRooms) 
        {
            this.gardenArea = gardenArea;
        }

        //Property - get/set for private instancevariables (encapsulation)
        public int GardenArea
        {
            get { return gardenArea; }
            set { gardenArea = value; }
        }

        //Abstract method inhereted from base class and implemented here
        public override void ResidentialAbstractMedthod(int var2)
        {
            this.GardenArea = var2;
        }
    }
}