using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Warehouse : Commercial
    {
        private bool haveOffice;

        public Warehouse()
        {

        }
     
       /* public Warehouse(int id, Address address, LegalForm legalForm, double squareMeter, bool haveOffice)
            : base (id, address, legalForm, squareMeter)
        {
            this.HaveOffice = haveOffice;
        } */

        public bool HaveOffice 
        {
            get { return haveOffice; }
            set { haveOffice = value;} 
        }

        public override int Price { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
    }
}