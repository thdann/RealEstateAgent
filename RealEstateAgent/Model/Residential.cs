using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealEstateAgent
{
    public abstract class Residential : Estate
    {
        // Instancevaiables specific to all Residential estates
        private int numberOfRooms;

        //Constructors
        public Residential() { }
        public Residential(int id, Address address, LegalForm legalForm, int price, int numberOfRooms) : base (id, address, legalForm, price) 
        {
            this.numberOfRooms = numberOfRooms;
        }

        //Property - get/set for private instancevariables (encapsulation)
     /*   public int NumberOfRooms {
            get { return numberOfRooms; }
            set { numberOfRooms = value; }
        } */
        public override int Attribute1
        {
            get { return numberOfRooms; }
            set { numberOfRooms = value; }
        }

        //Abstract method inhereted from base class and implemented here
        /*   public override void EstateAbstractMedthod(int var1, int var2)
           {
               this.NumberOfRooms = var1;
               ResidentialAbstractMedthod(var2);
           } */

        // Abstract method to be implemented downwards in subclasses
        //  public abstract void ResidentialAbstractMedthod(int var2);








        //public Residential(int id, Address address, LegalForm legalform, int numberOfRooms) 
        //    : base(id, address, legalform)
        //{
        //    this.numberOfRooms = numberOfRooms; 
        //}

    }

}