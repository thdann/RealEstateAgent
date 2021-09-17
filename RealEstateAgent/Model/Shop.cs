﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealEstateAgent
{
    public class Shop : Commercial
    {
        // Instancevaiables specific to all Shop estates
        private int numberOfElectricalSockets;

        //Constructors
        public Shop() { }

        public Shop(int id, Address address, LegalForm legalForm, int price, int squareMeters, int numberOfElectricalSockets) 
            : base(id, address, legalForm, price, squareMeters)
        {
            this.numberOfElectricalSockets = numberOfElectricalSockets;        
        }

        public int NumberOfElectricalSockets 
        {
            get { return numberOfElectricalSockets; }
            set { numberOfElectricalSockets = value; }
        }

    }
}