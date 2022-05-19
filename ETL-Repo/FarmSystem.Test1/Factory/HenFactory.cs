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
    /// Factory to execute tasks on Farm of Hen inherited from Animal
    /// </summary>
    class HenFactory : IAnimalFactory
    {
        /// <summary>
        /// Method to perform animal song
        /// </summary>
        public void Talk()
        {
            Console.WriteLine("Hen says CLUCKAAAAAWWWWK!");
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();            
            synth.Speak("Hen says CLUCKAAAAAWWWWK!");
            synth.Dispose();

        }

        /// <summary>
        /// Method to perform animal running
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Hen is running");
        }

    }
}
