using FarmSystem.Test.Factory;
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
    /// Factory to execute tasks on Farm of Horses inherited from Animal
    /// </summary>
    class HorseFactory : IAnimalFactory
    {
        /// <summary>
        /// Method to perform animal song
        /// </summary>
        public void Talk()
        {
            Console.WriteLine("Horse says neigh!");
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak("Horse says neigh!");
            synth.Dispose();
        }

        /// <summary>
        /// Method to perform animal running
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Horse is running");
        }

    }
}
