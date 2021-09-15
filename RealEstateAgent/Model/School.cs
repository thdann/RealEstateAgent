using System;
using System.Windows.Forms;

namespace RealEstateAgent
{
    public class School : Institutional 
    {
        // Instancevaiables specific to all School estates
        private int numberOfClassrooms;

        //Constructors
        public School(){
            
        }
        public School(int id, Address address, LegalForm legalForm, int price, int numberOfPeopleAllowed, int numberOfClassrooms) 
            : base (id,address, legalForm, price, numberOfPeopleAllowed) 
        {
            this.numberOfClassrooms = numberOfClassrooms;
        
        }

        public override int Attribute2 
        { 
            get { return numberOfClassrooms; }
            set { numberOfClassrooms = value; }
        }

        public override string ToString()
        {
            return base.ToString() + numberOfClassrooms;
        }
    }
}