using MonopolyApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyApp.Models
{
    class Player : IPlayer
    {
        public double Money { get; set; }
        public int Coordinate { get; set; }
        public List<Branch> Branches { get; set; }
        public string Name { get; set; }

        public void Color()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
