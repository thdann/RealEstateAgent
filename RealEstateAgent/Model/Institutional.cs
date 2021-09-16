
using System.Windows.Forms;

namespace RealEstateAgent
{
    public abstract class Institutional : Estate
    {
        // Instancevaiables specific to all Institutional estates
        private int numberOfPeopleAllowed;

        //Constructors
        public Institutional() { }

        public Institutional(int id, Address address, LegalForm legalForm, int price, int numberOfPeopleAllowed) 
            : base(id, address, legalForm, price) 
        {
            this.numberOfPeopleAllowed = numberOfPeopleAllowed;
        
        }

        //Here we override the Attribute1 to set specific attribute for all Institutional estetes
        public override int Attribute1
        {
            get { return numberOfPeopleAllowed; }
            set { numberOfPeopleAllowed = value; }
        }
 
    }
}