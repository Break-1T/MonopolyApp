using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;
using MonopolyApp.Models;

namespace MonopolyApp.Fields.Monopolies
{
    class Cosmetics : IMonopoly
    {
        public Cosmetics()
        {
            this._name = "Cosmetics";
            Chanel = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 3,
                Name = "Chanel",
                Owner = null,
                Price = 600,
                Tax = 50
            };
            LOreal = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 1,
                Name = "L’Oreal",
                Owner = null,
                Price = 500,
                Tax = 40
            };
            _allBranches = new List<Branch>() {Chanel, LOreal};
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

        public Branch Chanel { get; set; }
        public Branch LOreal { get; set; }
    }
}
