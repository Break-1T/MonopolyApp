using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Interfaces;
using MonopolyApp.Models;

namespace MonopolyApp.Fields.Monopolies
{
    class Technics:IMonopoly
    {
        public Technics()
        {
            this._name = "Technics";

            Google = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 37,
                Name = "Google",
                Owner = null,
                Price = 3200,
                Tax = 400
            };
            Apple = new Branch()
            {
                Appearance = new Image(),
                Coordinate = 39,
                Name = "Apple",
                Owner = null,
                Price = 3500,
                Tax = 450
            };
            _allBranches = new List<Branch>() { Apple, Google };
        }

        private string _name;
        private List<Branch> _allBranches;

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public List<Branch> AllBranches
        {
            get
            {
                return _allBranches;
            }
        }

        public Branch Apple { get; set; }
        public Branch Google { get; set; }
    }
}
