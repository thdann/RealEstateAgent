using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class University : Institutional
    {

        public University()
        {

        }
       /* public University(int id, Address address, LegalForm legalForm, int price) 
            : base(id, address, legalForm, price)
        {
        } */

        //TODo implementera price här!
        public override int Price { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }
    }
}