using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealEstateAgent
{
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

        //Here we override the Attribute2 to set specific attribute for all Warehouse estetes
        public override int Attribute2
        {
            get { return numberOfShelves; }
            set { numberOfShelves = value; }
        }

    }
}