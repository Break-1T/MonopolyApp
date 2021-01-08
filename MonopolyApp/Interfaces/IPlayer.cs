using MonopolyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyApp.Interfaces
{
    interface IPlayer
    {
        public double Money { get; set; }
        public List<Branch> Branches { get; set; }
        void Move();
        void Color();
    }
}
