using FarmSystem.Test.Interfaces.Services;
using FarmSystem.Test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test.Factory
{
    /// <summary>
    /// Factory to execute tasks on Farm of Cow inherited from Animal
    /// </summary>
    public class CowFactory : IAnimalFactory, IMilkableAnimal
    {
        /// <summary>
        /// Method to perform animal running
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Cow is running");

        }

        /// <summary>
        /// Method to perform animal song
        /// </summary>
        public void Talk()
        {
            Console.WriteLine("Cow says Moo!");
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Cow says Moo!");
            synth.Dispose();
        }

        protected void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }

    }
}
