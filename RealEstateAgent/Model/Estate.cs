﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace RealEstateAgent
{
    public abstract class Estate : IEstate
    {
        // Instancevaiables specific to all estates
        private int id;
        private Address address;
        private LegalForm legalForm;
        private int price;
        private Image estateImage;

        //Constructors
        public Estate() { }

        public Estate(int id, Address address, LegalForm legalForm, int price)
        {
            this.id = id;
            this.address = address;
            this.legalForm = legalForm;
            this.price = price;
        }

        //Properties - get/set for private instancevariables (encapsulation)
        public int Id { 
            get { return id; }
            set { id = value; }
        }
        public Address Address {
            get { return address; }
            set { address = value; }
        }
        public LegalForm LegalForm {
            get { return legalForm; }
            set { legalForm = value; } 
        }
        public int Price {
            get { return price; }
            set { price = value; }        
        }
        public Image EstateImage
        {
            get { return estateImage; }
            set { estateImage = value; }
        }

        //An abstract property to set and get the specific attribute for each estatetype
        public abstract int Attribute1
        {
            get; set;
        }

        //An abstract property to set and get the specific attribute for each buildingtype
        public abstract int Attribute2
        {
            get; set;
        }


        //A string formatted to one line
        public override string ToString()
        {

            string strEstate = String.Format(" {0}, {1}, {2}, {3}",
              id, LegalForm, Price, address.ToString());

            return strEstate;
        }

    }
}