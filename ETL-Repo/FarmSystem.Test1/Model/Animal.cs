using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test.Model
{
    public abstract class Animal
    {
        private string _id;
        private string Id { get => _id; set => _id = Guid.NewGuid().ToString(); }
        public abstract string Name { get; }
        public abstract int NoOfLegs { get; protected set; }

        protected Animal(int noOfLegs)
        {
            NoOfLegs = noOfLegs;
        }

        

    }
}
