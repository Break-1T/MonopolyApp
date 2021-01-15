using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;
using MonopolyApp.Models;

namespace MonopolyApp.Fields.Monopolies
{
    class Drinks :IMonopoly
    {
        public Drinks()
        {
            this._name = "Drinks";
            RedBull = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 16,
                Name = "RedBull",
                Owner = null,
                Price = 1800,
                Tax = 200
            };
            PepsiCola = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 18,
                Name = "Pepsi-Cola",
                Owner = null,
                Price = 1900,
                Tax = 220
            };
            CocaCola = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 19,
                Name = "Coca-Cola",
                Owner = null,
                Price = 2000,
                Tax = 240
            };
            _allBranches = new List<Branch>() { CocaCola, PepsiCola, RedBull };
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

        public Branch CocaCola { get; set; }
        public Branch PepsiCola { get; set; }
        public Branch RedBull { get; set; }
    }
}
