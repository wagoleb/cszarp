using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class ProdFib
    {
        public static int Fibonacci(int prod)
        {
            if (prod == 1)
            {
                return 0;
            }
            else if ( prod >=2 && prod <= 3)
            {
                return 1;
            }
            else
            {
                return Fibonacci(prod - 1) + Fibonacci(prod - 2);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProdFib.Fibonacci(10));
        }
    }
}
