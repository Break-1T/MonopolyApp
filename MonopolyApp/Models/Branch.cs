using MonopolyApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyApp.Models
{
    class Branch : IBranch
    {
        public double Price => throw new NotImplementedException();

        public Monopoly MonopolyType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Player Owner { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
