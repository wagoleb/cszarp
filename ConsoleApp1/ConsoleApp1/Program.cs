using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Punkt
    {
        public int X
        {
            get;
            private set;
        }
        public int Y
        {
            get;
            private set;
        }

        public Punkt(int x = 0, int y = 0)
        {
            this.X = x;
            this.Y = y;
        }

        virtual public string pokazWsp()
        {
            return String.Format("({0},{1})", this.X, this.Y);
        }
    }

    class Punkt3D : Punkt
    {
        public int Z
        {
            get;
            private set;
        }

        public Punkt3D(int x = 0, int y = 0, int z = 0) : base(x, y)
        {
            this.Z = z;
        }
        override public string pokazWsp()
        {
            return String.Format("{0},{1}", base.pokazWsp(), this.Z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Punkt a = new Punkt(4, 6);
            Console.WriteLine(a.pokazWsp());
            Punkt3D b = new Punkt3D(10, 20, 30);
            Console.WriteLine(b.pokazWsp());
        }
    }
}
