using System;
using System.Windows.Forms;

namespace RealEstateAgent
{
    public class University : Institutional
    {
        //Instancevaiables specific to all University estates
        private int numberOfOffices;

        //Constructors
        public University() { }
        public University(int id, Address address, LegalForm legalForm, int price, int numberOfPeopleAllowed, int numberOfOffices) 
            : base(id, address, legalForm, price, numberOfPeopleAllowed) 
        { 
            this.numberOfOffices = numberOfOffices; 
        }

        //Property - get/set for private instancevariables (encapsulation)
   /*     public int NumberOfOffices 
        {
            get { return numberOfOffices; }
            set { numberOfOffices = value; }
        } */
        public override int Attribute2
        {
            get { return numberOfOffices; }
            set { numberOfOffices = value; }
        }
        //Abstract method inhereted from base class and implemented here
    /*    public override void InstitutionallAbstractMedthod(int var2)
        {
            this.NumberOfOffices = var2;
        } */
    }
}