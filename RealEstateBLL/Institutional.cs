using System;


namespace RealEstateAgent
{
    [Serializable]
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

        //Properties - get/set for private instancevariables (encapsulation)
        public int NumberOfPeopleAllowed
        {
            get { return numberOfPeopleAllowed; }
            set { numberOfPeopleAllowed = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"{numberOfPeopleAllowed}, ";
        }

    }
}