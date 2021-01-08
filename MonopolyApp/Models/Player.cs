using MonopolyApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyApp.Models
{
    class Player : IPlayer
    {
        public double Money { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Branch> Branches { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
