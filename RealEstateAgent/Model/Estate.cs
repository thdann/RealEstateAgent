using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealEstateAgent
{
    public abstract class Estate : IEstate
    {
        private int id;
        private Address address;
        private LegalForm legalForm;
        private int price;

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

        // Abstract method to be implemented downwards in subclasses
        public abstract void EstateAbstractMedthod(int var1, int var2);

        public override String ToString() {

            return id.ToString();
        
        
        }

    }
}