using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Warehouse : Commercial
    {
       // private bool haveOffice;
       //Är hela grejen med propierties att man kanske inte behöver deklarare en variabel?
       // utan man kallar på propierties i konstruktorn, se nedan

        public Warehouse(int id, Address address, double squareMeter, bool haveOffice)
            : base (id, address, squareMeter)
        {
            this.HaveOffice = haveOffice;
        }

        public bool HaveOffice { get; set; }
        public override double SquareMeter {  
           get => throw new NotImplementedException(); 
           set => throw new NotImplementedException(); 
        }
        public override int Id { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public override Address Address { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public override LegalForm LegalForm { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
    }
}