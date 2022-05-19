using FarmSystem.Test.Factory;
using FarmSystem.Test.Interfaces.Services;
using FarmSystem.Test.Model;
using FarmSystem.Test1;
using FarmSystem.Test1.Interfaces.Repositories;
using FarmSystem.Test1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;

namespace FarmSystem.Test.Services
{
    public class EmydexFarmSystem
    {
        public IAnimalRepository _repository = new AnimalRepository();
    
        //TEST 1
        public void Enter(object obj)
        {
            //Display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            Animal animal = (Animal)obj;
            _repository.Add(animal);
            Console.WriteLine($"{animal.Name} has entered the Emydex farm");
        }

        /// <summary>
        /// Method to perform song all animals that are on the farm
        /// </summary>
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk

            try
            {
                
                foreach (Animal animal in _repository.GetAll())
                {
                    IAnimalFactory factory = null;
                    switch (animal.Name.ToLower())
                    {
                        case "cow":
                            factory = new CowFactory();
                            break;
                        case "hen":
                            factory = new HenFactory();
                            break;
                        case "horse":
                            factory = new HorseFactory();
                            break;
                        case "sheep":
                            factory = new SheepFactory();
                            break;
                        default:
                            break;
                    }
                    factory.Talk();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
            }
        }

        /// <summary>
        /// Method to perform milking task for those who produce Milk
        /// </summary>
        //TEST 3
        public void MilkAnimals()
        {
            try
            {
                
                foreach (Animal animal in _repository.GetAll())
                {
                    IMilkableAnimal factory = null;

                    switch (animal.Name.ToLower())
                    {
                        case "cow":
                            factory = new CowFactory();
                            factory.ProduceMilk();
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        /// <summary>
        /// Method to perform left of all farm animals
        /// </summary>
        //TEST 4
        public void ReleaseAllAnimals()
        {
            try
            {
                Queue<Animal> release = _repository.GetAll();
                int amount = _repository.GetAll().Count;
                for (int i = 0; i < amount; i++)
                {
                    if (FarmContext.Animals.Any())
                    {
                        Console.WriteLine($"{release.Peek().Name} left the farm");
                        Animal animal = release.Dequeue();
                    }
                }

                //Animals.Except(release);

                if (release.Count > 0)
                    Console.WriteLine("There are still animals in the farm, farm is not free");
                FarmContext.Animals.Clear();
                Console.WriteLine("Farm is free");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    
    }
}