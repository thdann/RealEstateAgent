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

        public Residential(int id, Address address, LegalForm legalForm, int price, int numberOfRooms) 
            : base (id, address, legalForm, price) 
        {
            this.numberOfRooms = numberOfRooms;
        }

        //Properties - get/set for private instancevariables (encapsulation)
        public int NumberOfRooms
        {
            get { return numberOfRooms; }
            set { numberOfRooms = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"{numberOfRooms}, ";
        }
    }

}