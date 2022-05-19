using FarmSystem.Test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    /// <summary>
    /// Context Class to represent interaction with data on database 
    /// For future database extension requirement
    /// </summary>
    public class FarmContext
    {
        public static Queue<Animal> Animals = new Queue<Animal>();

    }
}
