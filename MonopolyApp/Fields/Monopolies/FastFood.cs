using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;
using MonopolyApp.Models;

namespace MonopolyApp.Fields.Monopolies
{
    class FastFood:IMonopoly
    {
        public FastFood()
        {
            this._name = "FastFood";
            DominosPizza = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 26,
                Name = "Domino’s Pizza",
                Owner = null,
                Price = 2400,
                Tax = 300
            };
            KFC = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 27,
                Name = "KFC",
                Owner = null,
                Price = 2500,
                Tax = 310
            };
            McDonalds = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 29,
                Name = "McDonald's",
                Owner = null,
                Price = 2600,
                Tax = 320
            };
            _allBranches = new List<Branch>() { McDonalds, KFC, DominosPizza };
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

        public Branch McDonalds  { get; set; }
        public Branch KFC { get; set; }
        public Branch DominosPizza { get; set; }
    }
}
