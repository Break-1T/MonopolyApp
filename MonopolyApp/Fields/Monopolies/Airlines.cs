using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;
using MonopolyApp.Models;

namespace MonopolyApp.Fields.Monopolies
{
    class Airlines :IMonopoly
    {
        public Airlines()
        {
            this._name = "Airlines";
            AmericanAirlines = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 21,
                Name = "American Airlines",
                Owner = null,
                Price = 2100,
                Tax = 260
            };
            Lufthansa = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 23,
                Name = "Lufthansa",
                Owner = null,
                Price = 2200,
                Tax = 270
            };
            Emirates = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 24,
                Name = "Emirates",
                Owner = null,
                Price = 2300,
                Tax = 280
            };
            _allBranches = new List<Branch>() { Emirates, Lufthansa, AmericanAirlines };
        }

        private string _name;
        private List<Branch> _allBranches;

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public List<Branch> AllBranches
        {
            get
            {
                return _allBranches;
            }
        }

        public Branch Emirates { get; set; }
        public Branch Lufthansa { get; set; }
        public Branch AmericanAirlines { get; set; }
    }
}

