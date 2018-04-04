using System;
using System.Linq;


namespace ConsoleApp1
{
    public class Kata
    {
        public static string BreakCamelCase(string str)
        {
            string result = "";
            int start = 0, end = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString().Any(char.IsUpper) == true)
                {
                    result += " " + str[i];
                }
                else
                {
                    result += str[i];
                }
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.BreakCamelCase("camelCasingTest"));
        }
    }
}
