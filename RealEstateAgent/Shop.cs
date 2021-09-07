using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Shop : Commercial
    {
       // private bool hasFurnishing;

        public Shop (int id, Address address, double squareMeter, bool hasFurnishing)
            : base (id, address, squareMeter)
        {
            HasFurnishing = hasFurnishing;
        }

        public bool HasFurnishing { get; set; }

        public override double SquareMeter 
        { get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public override int Id 
        { get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public override Address Address 
        { get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public override LegalForm LegalForm 
        { get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
    }
}