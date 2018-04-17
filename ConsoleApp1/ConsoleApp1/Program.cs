using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    public static class Kata
    {
        public static string sumStrings(string a, string b)
        {
            int maxLength = (a.Length >= b.Length) ? a.Length : b.Length;
            for ( int i = maxLength-1; i > -1; i--)
            {
                Console.WriteLine("{0} - {1}", a[i], b[i]);
            }
            return Convert.ToString(maxLength);
        }
    }
    class Program
    {

        public static void Main(string[] args)
        {
            // Kata.sumStrings("1234", "456");
            string slowo = "wojtek";
            IEnumerable<char> nowe = slowo.Reverse();
            Console.WriteLine((string)nowe);
        }
    }
}
