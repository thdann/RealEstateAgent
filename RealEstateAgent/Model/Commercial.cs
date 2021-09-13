using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Commercial : Estate
    {
        private double squareMeter;

        public Commercial ()
        {

        }
    /*    public Commercial(int id, Address address, LegalForm legalForm, double squareMeter) : base(id, address, legalForm)
        {
            this.squareMeter = squareMeter;
        }
    */
        public double SquareMeter
        {
            get { return squareMeter; }
            set { squareMeter = value; }
        }
    }
}
