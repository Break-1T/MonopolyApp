using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;
using MonopolyApp.Models;

namespace MonopolyApp.Fields.Special_fields
{
    class Questions
    {
        public Questions()
        {
            Q1 = new Question()
            {
                Appearance = new Image(),
                Coordinate = 2,
                Name = "First Question field"
            };
            Q2 = new Question()
            {
                Appearance = new Image(),
                Coordinate = 7,
                Name = "Second Question field"
            };
            Q3 = new Question()
            {
                Appearance = new Image(),
                Coordinate = 17,
                Name = "Third Question field"
            };
            Q4 = new Question()
            {
                Appearance = new Image(),
                Coordinate = 22,
                Name = "Fourth Question field"
            };
            Q5 = new Question()
            {
                Appearance = new Image(),
                Coordinate = 33,
                Name = "Fifth Question field"
            };
            Q6 = new Question()
            {
                Appearance = new Image(),
                Coordinate = 38,
                Name = "Sixth Question field"
            };
        }
        public Question Q1 { get; set; }
        public Question Q2 { get; set; }
        public Question Q3 { get; set; }
        public Question Q4 { get; set; }
        public Question Q5 { get; set; }
        public Question Q6 { get; set; }
    }
}
