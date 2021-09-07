using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Commercial : Estate
    {
        private double squareMeter;
        public Commercial(int id, Address address, double squareMeter) :  base(id, address)
        {
            this.squareMeter = squareMeter;
        }

        public abstract double SquareMeter { get; set; }
    }
}