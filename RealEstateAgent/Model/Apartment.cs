using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealEstateAgent
{
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

        public override int Attribute2 {
            get { return floor; }
            set { floor = value; }
        }

    }

 }