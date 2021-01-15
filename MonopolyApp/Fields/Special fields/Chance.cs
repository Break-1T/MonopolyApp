using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;

namespace MonopolyApp.Fields.Special_fields
{
    class Chance :IField
    {
        public Chance()
        {
            this.Name = "Chance";
            this.Coordinate = 30;
            this.Appearance = new Image();
        }

        public string Name { get; set; }
        public int Coordinate { get; set; }
        public Image Appearance { get; set; }
    }
}
