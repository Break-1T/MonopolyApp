using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace MonopolyApp.Interfaces
{
    interface IField
    {
        string Name { get; set; }
        int Coordinate { get; set; }
        Image Appearance { get; set; }
    }
}
