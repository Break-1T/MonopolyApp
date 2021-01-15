using MonopolyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyApp.Interfaces
{
    interface IPlayer
    {
        string Name { get; set; }
        double Money { get; set; }
        int Coordinate { get; set; }
        public List<Branch> Branches { get; set; }
        void Move();
        void Color();
    }
}
