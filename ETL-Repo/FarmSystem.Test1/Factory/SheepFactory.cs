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
    /// Factory to execute tasks on Farm of Sheep inherited from Animal
    /// </summary>
    class SheepFactory : IAnimalFactory
    {
        /// <summary>
        /// Method to perform animal song
        /// </summary>
        public void Talk()
        {
            Console.WriteLine("Sheep says baa!");
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Sheep says baa!");
            synth.Dispose();
        }


        /// <summary>
        /// Method to perform animal running
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Sheep is running");
        }


        
    }
}
