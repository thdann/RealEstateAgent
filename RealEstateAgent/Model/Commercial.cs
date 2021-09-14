
using System.Windows.Forms;

namespace RealEstateAgent
{
    public abstract class Commercial : Estate
    {
        // Instancevaiables specific to all Commercial estates
        private int squareMeter;

        //Constructors
        public Commercial () { }

        public Commercial (int id, Address address, LegalForm legalForm, int price, int squareMeters ) : base(id, address, legalForm, price) 
        {
            this.squareMeter = squareMeters;        
        }
        
        //Property - get/set for private instancevariables (encapsulation)
        public int SquareMeter
        {
            get { return squareMeter; }
            set { squareMeter = value; }
        }

        //Abstract method inhereted from base class and implemented here
        public override void EstateAbstractMedthod(int var1, int var2)
        {
            this.squareMeter = var1;
            CommercialAbstractMedthod(var2);
        }

        // Abstract method to be implemented downwards in subclasses

        public abstract void CommercialAbstractMedthod(int var2);





        /*    public Commercial(int id, Address address, LegalForm legalForm, double squareMeter) : base(id, address, legalForm)
    {
        this.squareMeter = squareMeter;
    }
*/

    }
}
