using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;
using MonopolyApp.Models;

namespace MonopolyApp.Fields.Monopolies
{
    class Hotels:IMonopoly
    {
        public Hotels()
        {
            this._name = "Hotels";
            Radisson = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 31,
                Name = "Radisson",
                Owner = null,
                Price = 2700,
                Tax = 330
            };
            HolidayInn = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 32,
                Name = "Holiday Inn",
                Owner = null,
                Price = 2800,
                Tax = 330
            };
            MarriottInternational = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 34,
                Name = "Marriott International",
                Owner = null,
                Price = 3000,
                Tax = 350
            };
            _allBranches = new List<Branch>() { MarriottInternational, HolidayInn, Radisson };
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

        public Branch MarriottInternational { get; set; }
        public Branch HolidayInn  { get; set; }
        public Branch Radisson { get; set; }
    }
}
