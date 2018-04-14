using System;
using System.Collections;
using System.Linq;


namespace ConsoleApp1
{
    public class Kata
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            for ( int i = 0; i < s.Length; i++)
            {
                string getLower = s.ToLower();
                if (getLower.Count(x => x == getLower[i]) == 1)
                {
                    return Convert.ToString(s[i]);
                }
            }
            return "";
        }
    }

    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(Kata.FirstNonRepeatingLetter("wwoojjTeekk"));
        }
    }
}
