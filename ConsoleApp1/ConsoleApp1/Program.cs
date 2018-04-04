using System;
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kata
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char pierwsza = s.Substring(i)[0];
                string reszta = s.Substring(i);

                if (reszta.Count(f => f == pierwsza) == 1)
                {
                    return pierwsza.ToString();
                }

            }
            return "";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.FirstNonRepeatingLetter("moonmen"));
        }
    }
}
