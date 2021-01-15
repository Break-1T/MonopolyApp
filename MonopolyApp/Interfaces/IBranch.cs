using MonopolyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace MonopolyApp.Interfaces
{
    interface IBranch:IField
    {
        double Price { get; }
        double Tax { get; set; }
        
        Player Owner { get; set; }
    }
}
