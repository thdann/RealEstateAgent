using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Shop : Commercial
    {
        private bool hasFurnishing;

        public Shop (int id, Address address, LegalForm legalForm, double squareMeter, bool hasFurnishing)
            : base (id, address, legalForm, squareMeter)
        {
            this.hasFurnishing = hasFurnishing;
        }

        public bool HasFurnishing
        {
            get { return hasFurnishing; }
            set { hasFurnishing = value; }
        }
        public override int Price { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
    }
}