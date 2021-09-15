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

        //Property - get/set for private instancevariables (encapsulation)
     /*   public int NumberOfShelves {
            get { return numberOfShelves; }
            set { numberOfShelves = value; } 
        } */

        public override int Attribute2
        {
            get { return numberOfShelves; }
            set { numberOfShelves = value; }
        }

        //Abstract method inhereted from base class and implemented here
     /*   public override void CommercialAbstractMedthod(int var2)
        {
            this.NumberOfShelves = var2;
        } */






        /* public Warehouse(int id, Address address, LegalForm legalForm, double squareMeter, bool haveOffice)
     : base (id, address, legalForm, squareMeter)
 {
     this.HaveOffice = haveOffice;
 } */

    }
}