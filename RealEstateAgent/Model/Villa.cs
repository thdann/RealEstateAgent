using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Villa : Residential
    {
        private int gardenArea;

        public Villa() { }

       /* public Villa(int id, Address address, LegalForm legalform, int numberOfRooms, int gardenArea)
            : base(id, address, legalform, numberOfRooms)
        {
            this.gardenArea = gardenArea;
        } */

        public int GardenArea
        {
            get { return gardenArea; }
            set { gardenArea = value; }
        }

        //TODO: implementera denna här!
        public override int Price
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}