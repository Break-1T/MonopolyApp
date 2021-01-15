using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;
using MonopolyApp.Models;

namespace MonopolyApp.Fields.Monopolies
{
    class Cryptocurrency : IMonopoly
    {
        public Cryptocurrency()
        {
            this._name = "Cryptocurrency";
            Ethereum = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 9,
                Name = "Ethereum",
                Owner = null,
                Price = 1500,
                Tax = 500
            };
            Bitcoin = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 8,
                Name = "Bitcoin",
                Owner = null,
                Price = 1500,
                Tax = 500
            };
            _allBranches = new List<Branch>() { Bitcoin, Ethereum };
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

        public Branch Bitcoin { get; set; }
        public Branch Ethereum { get; set; }
    }
}
