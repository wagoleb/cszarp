using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public static class Kata
    {
        public static int getFactorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * getFactorial(n - 1);
            }
        }

        public static int TrailingZeros(int n)
        {
            string number = getFactorial(n).ToString();
            int counter = 0;
            for (int i = number.Length-1; i >= 0; i--)
            {
                if (number[i].ToString() == "0")
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.TrailingZeros(12));
        }
    }
}
