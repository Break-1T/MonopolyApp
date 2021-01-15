using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;
using MonopolyApp.Models;

namespace MonopolyApp.Fields.Monopolies
{
    class Clothes:IMonopoly
    {
        public Clothes()
        {
            this._name = "Clothes";
            Nike = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 9,
                Name = "Nike",
                Owner = null,
                Price = 1200,
                Tax = 150
            };
            Adidas = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 8,
                Name = "Adidas",
                Owner = null,
                Price = 1100,
                Tax = 120
            };
            Reebok = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 6,
                Name = "Reebok",
                Owner = null,
                Price = 1000,
                Tax = 100
            };
            _allBranches = new List<Branch>() {Nike,Adidas,Reebok };
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

        public Branch Nike { get; set; }
        public Branch Adidas { get; set; }
        public Branch Reebok { get; set; }
    }
}
