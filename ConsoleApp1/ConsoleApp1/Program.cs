using System;
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Nowa
    {
        private string _myprops;
        public string MyProperty
        {
            get
            {
                Console.WriteLine("getter");
                if (!String.IsNullOrEmpty(_myprops))
                {
                    Console.WriteLine("Nie pusty");
                    return _myprops;
                }
                else
                {
                    Console.WriteLine("PUSTY!");
                    return "";
                }
            }
            set
            {
                Console.WriteLine("setter");
                if (!String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("OK");
                    _myprops = value;
                }
                else
                {
                    Console.WriteLine("Pusty");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Nowa obiekt1 = new Nowa();
            string nowy = obiekt1.MyProperty;

        }
    }
}
