using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;

namespace MonopolyApp.Fields.Special_fields
{
    class Start : IField
    {
        public Start()
        {
            this.Name = "Start";
            this.Coordinate = 0;
            this.Appearance = new Image();
        }
        
        public string Name { get; set; }
        public int Coordinate { get; set; }
        public Image Appearance { get; set; }

    }
}
