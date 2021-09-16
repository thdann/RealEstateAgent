using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealEstateAgent
{
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

        //Here we override the Attribute2 to set specific attribute for all Villa estetes
        public override int Attribute2
        {
            get { return gardenArea; }
            set { gardenArea = value; }
        }

    }
}