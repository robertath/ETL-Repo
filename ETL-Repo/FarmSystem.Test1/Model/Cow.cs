using FarmSystem.Test.Model;
using System;

namespace FarmSystem.Test
{
    class Cow : Animal
    {
        private readonly string _name;
        private int _noOfLegs;

        public override string Name { get => _name; }
        public override int NoOfLegs { get => _noOfLegs; protected set { _noOfLegs = value; } }

        public Cow(int noOfLegs) : base(noOfLegs)
        {
            _name = "Cow";
            _noOfLegs = noOfLegs;
        }
    }
}