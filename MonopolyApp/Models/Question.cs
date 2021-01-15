using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;

namespace MonopolyApp.Models
{
    class Question : IQuestion
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Coordinate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Image Appearance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
