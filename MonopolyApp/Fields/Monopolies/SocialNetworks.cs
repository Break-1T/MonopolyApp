using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;
using MonopolyApp.Models;

namespace MonopolyApp.Fields.Monopolies
{
    class SocialNetworks:IMonopoly
    {
        public SocialNetworks()
        {
            this._name = "SocialNetworks";
            Telegram = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 11,
                Name = "Telegram",
                Owner = null,
                Price = 1500,
                Tax = 180
            };
            Instagram = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 13,
                Name = "Instagram",
                Owner = null,
                Price = 1600,
                Tax = 200
            };
            YouTube = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 14,
                Name = "YouTube",
                Owner = null,
                Price = 1700,
                Tax = 220
            };
            _allBranches = new List<Branch>() { YouTube, Instagram, Telegram };
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

        public Branch YouTube { get; set; }
        public Branch Instagram { get; set; }
        public Branch Telegram { get; set; }
    }
}
