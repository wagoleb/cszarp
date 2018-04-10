using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nowaLista = new ArrayList();
           nowaLista.Add(5);
            nowaLista.Add(5);
            nowaLista.Add("wojtek");
            nowaLista.Add("g");

            foreach (var item in nowaLista)
	{
                Console.WriteLine(item);
	}
            Console.WriteLine(nowaLista[2]);
            Console.ReadKey();
        }
    }
}
