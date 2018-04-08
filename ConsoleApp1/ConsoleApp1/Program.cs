using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class SumSquaredDivisors 
    {
	
        public static string listSquared(long m, long n)
        {
            string result = "";
            for (long i = m; i <= n; i++)
	        {
                List<long> divisors=new List<long>();
                for (int j = 1; j <= (i/2); j++)
                {
                    if (i % j == 0)
                    {
                        divisors.Add(j);
                    }
                }
                divisors.Add(i);
                
                List<long> squared = new List<long>();

                for (int k = 0; k < divisors.Count(); k++)
			    {
                    squared.Add(divisors[k]*divisors[k]);
			    }
                /*
                foreach (var item in squared)
	            {
                    Console.Write("{0} ", item);
	            }
                Console.WriteLine();
                */
                double value = Math.Sqrt(((double)squared.Sum()));
                if (value % 2 == 0 && (value * value) == squared.Sum())
                {
                    Console.WriteLine("[{0}, {1}]", i, squared.Sum());
                }
            }
        
	    return result;
        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumSquaredDivisors.listSquared(1,250));;
            Console.ReadKey();
        }
    }
}
