using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;
using MonopolyApp.Models;

namespace MonopolyApp.Fields.Monopolies
{
    class Cars : IMonopoly
    {
        public Cars()
        {
            this._name = "Cars";
            Audi = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 5,
                Name = "Audi",
                Owner = null,
                Price = 2000,
                Tax = 250
            };
            BMW = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 15,
                Name = "BMW",
                Owner = null,
                Price = 2000,
                Tax = 250
            };
            LADA = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 25,
                Name = "LADA",
                Owner = null,
                Price = 2000,
                Tax = 250
            };
            ZAZ = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 35,
                Name = "ZAZ",
                Owner = null,
                Price = 2000,
                Tax = 250
            };
            _allBranches = new List<Branch>() { Audi,BMW,LADA, ZAZ };
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

        public Branch Audi { get; set; }
        public Branch BMW { get; set; }
        public Branch LADA { get; set; }
        public Branch ZAZ { get; set; }
    }
}
