using MonopolyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyApp.Interfaces
{
    interface IBranch
    {
        public double Price { get; }
        public Monopoly MonopolyType { get; set; }
        public Player Owner { get; set; } 
    }
}
