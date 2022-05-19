using FarmSystem.Test.Model;
using FarmSystem.Test1.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1.Repositories
{
    /// <summary>
    /// Repository Class to manage the models of farm on content data driver
    /// </summary>
    public class AnimalRepository : IAnimalRepository
    {

        public bool Add(Animal animal)
        {
            try
            {
                FarmContext.Animals.Enqueue(animal);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool Remove()
        {
            try
            {
                
                Animal next = FarmContext.Animals.Dequeue();
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return false;
            }
        }

        public Queue<Animal> GetAll()
        {
            try
            {
                return FarmContext.Animals;
            }
            catch
            {
                throw new Exception("Error to recover Animals.");
            }
        }


        public void Dispose()
        {
               
            GC.SuppressFinalize(this);
        }
    }
}
