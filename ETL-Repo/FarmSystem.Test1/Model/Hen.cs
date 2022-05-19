using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test.Model
{
    internal class Hen : Animal
    {
        private readonly string _name;
        private int _noOfLegs;

        public override string Name { get => _name; }
        public override int NoOfLegs { get => _noOfLegs; protected set { _noOfLegs = value; } }


        public Hen(int noOfLegs) : base(noOfLegs)
        {
            _name = "Hen";
            _noOfLegs = noOfLegs;
        }
    }
}
