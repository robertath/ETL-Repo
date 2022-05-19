using FarmSystem.Test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1.Interfaces.Repositories
{
    public interface IAnimalRepository : IDisposable
    {
        Queue<Animal> GetAll();
        bool Add(Animal agency);
        bool Remove();
        
    }
}
