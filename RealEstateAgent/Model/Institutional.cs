
using System.Windows.Forms;

namespace RealEstateAgent
{
    public abstract class Institutional : Estate
    {
        // Instancevaiables specific to all Institutional estates
        private int numberOfPeopleAllowed;

        //Constructors
        public Institutional() { }

        public Institutional(int id, Address address, LegalForm legalForm, int price, int numberOfPeopleAllowed) : base(id, address, legalForm, price) 
        {
            this.numberOfPeopleAllowed = numberOfPeopleAllowed;
        
        }

        //Property - get/set for private instancevariables (encapsulation)
        public int NumberOfPeopleAllowed 
        {
            get { return numberOfPeopleAllowed; }
            set { numberOfPeopleAllowed = value; }
        }

        //Abstract method inhereted from base class and implemented here
        public override void EstateAbstractMedthod(int var1, int var2)
        {
            this.NumberOfPeopleAllowed = var1;
            InstitutionallAbstractMedthod(var2);
        }

        // Abstract method to be implemented downwards in subclasses
        public abstract void InstitutionallAbstractMedthod(int var2);

    }
}