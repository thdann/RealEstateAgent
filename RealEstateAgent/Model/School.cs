using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class School : Institutional
    {
        public School(int id, Address address, LegalForm legalForm, int price) 
            : base(id, address, legalForm, price)
        {
        }

        //ToDO implementera price här
        public override int Price { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }
    }
}