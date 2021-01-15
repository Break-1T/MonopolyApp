using MonopolyApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace MonopolyApp.Models
{
    class Player : IPlayer
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public int Coordinate { get; set; }
        
        public Image Appearance { get; set; }
        
        public List<Branch> Branches { get; set; }

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
