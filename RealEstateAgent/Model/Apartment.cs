using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Apartment : Residential
    {
        private bool hasElevator;

        public Apartment()
        {

        }

      /*  public Apartment(int id, Address address, LegalForm legalform, int numberOfRooms, bool hasElevator) 
            : base(id, address, legalform, numberOfRooms)
        {
            this.hasElevator = hasElevator;
        } */

        public bool HasElevator
        {
            get { return hasElevator; }
            set { hasElevator = value; }
        }

        // TODO: implementera denna metod här!
        public override int Price
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
 }