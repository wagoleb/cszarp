using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp1
{

    class Program
    {
        public static void Main(string[] args)
        {
            int a = 5, b = 0;
            try
            {
                int c = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("dzielenie przez zero");
                Console.WriteLine(e.Message);

                int? x;
                x = null;
                x= 56;
                Nullable<int> y;
                y = null;

                int z;

                z = x ?? 0;
                Console.WriteLine(z);
                Console.ReadKey();
            }
        }
    }
}
