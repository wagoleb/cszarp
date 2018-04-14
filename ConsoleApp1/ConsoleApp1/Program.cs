using System;
using System.Collections;
using System.Linq;


namespace ConsoleApp1
{
    static class StringExtend
    {
        public static int CountChar(this string word, char n)
        {
            return word.Count(x => x == n);
        }
    }

    class Program
    {

        public static void Main(string[] args)
        {
            string wyrazenie = "wwwoooojjjteeekkkkkkkkkkkkkkoo";
            foreach (var item in wyrazenie)
            {
                Console.WriteLine("znak {0} wystepuje {1} razy", item, wyrazenie.CountChar(item));
            }

            Console.ReadKey();
        }
    }
}
