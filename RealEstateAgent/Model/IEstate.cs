using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public interface IEstate
    {
        public int Id { get; set; }

        public Address Address { get; set; }

    }
}