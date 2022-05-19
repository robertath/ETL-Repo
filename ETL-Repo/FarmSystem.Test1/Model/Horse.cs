using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test.Model
{
    class Horse : Animal
    {
        private readonly string _name;
        private int _noOfLegs;

        public override string Name { get => _name; }
        public override int NoOfLegs { get => _noOfLegs; protected set { _noOfLegs = value; } }

        public Horse(int noOfLegs) :base(noOfLegs)
        {
            _name = "Horse";
            _noOfLegs = noOfLegs;
            
        }
    }
}
