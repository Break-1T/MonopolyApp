using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;

namespace MonopolyApp.Fields.Special_fields
{
    class Jail:IField
    {
        public Jail()
        {
            this.Name = "Jail";
            this.Coordinate = 10;
            this.Appearance = new Image();
        }

        public string Name { get; set; }
        public int Coordinate { get; set; }
        public Image Appearance { get; set; }
    }
}
