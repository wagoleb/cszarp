using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> start = new List<int>(), zerowa = new List<int>();
            foreach (var item in arr)
            {
                if (item != 0)
                {
                    start.Add(item);
                }
                else
                {
                    zerowa.Add(item);
                }
            }
            start.AddRange(zerowa);
            arr = start.ToArray();
            return arr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }))
            {
                Console.Write(item + " ");
            }
        }
    }
}
