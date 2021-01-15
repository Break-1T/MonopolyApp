using MonopolyApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace MonopolyApp.Models
{
    class Branch : IBranch
    {
        public string Name { get; set; }
        public int Coordinate { get; set; }

        public double Price { get; set; }
        public double Tax { get; set; }

        public Player Owner { get; set; }
        public Image Appearance { get; set; }
    }
}
