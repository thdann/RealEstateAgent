
using System.Windows.Forms;

namespace RealEstateAgent
{
    public abstract class Commercial : Estate
    {
        // Instancevaiables specific to all Commercial estates
        private int squareMeter;

        //Constructors
        public Commercial () { }

        public Commercial (int id, Address address, LegalForm legalForm, int price, int squareMeters ) 
            : base(id, address, legalForm, price) 
        {
            this.squareMeter = squareMeters;        
        }

        //Properties - get/set for private instancevariables (encapsulation)
        public int SquareMeter
        {
            get { return squareMeter; }
            set { squareMeter = value; }
        }

    }
}
