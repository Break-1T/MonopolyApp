using MonopolyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace MonopolyApp.Interfaces
{
    interface IPlayer
    {
        string Name { get; set; }
        double Money { get; set; }
        int Coordinate { get; set; }
        
        Image Appearance { get; set; }

        public List<Branch> Branches { get; set; }
        
        void Move();
        void Color();
    }
}
