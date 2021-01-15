using System;
using System.Collections.Generic;
using System.Text;
using MonopolyApp.Models;

namespace MonopolyApp.Interfaces
{
    interface IMonopoly
    {
        string Name { get;}
        List<Branch> AllBranches { get;} 
    }
}
