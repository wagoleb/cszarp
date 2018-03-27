using System;
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer mowa = new SpeechSynthesizer();
            mowa.Speak("what the fuck is going on?");
        }
    }
}
