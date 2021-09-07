using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Commercial : Estate
    {
        public Commercial(int id, Address address) :  base(id, address)
        {
            
        }
    }
}