using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp1
{
    class Point
    {
        private int X;
        private int Y;

        public Point()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;

        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", this.X, this.Y);
        }

        public static bool operator ==(Point a, Point b)
        {
            if (a.X == b.X && a.Y == b.Y)
                return true;
            else
                return false;

        }

        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point((a.X + b.X), (a.Y + b.Y));
        }
        public static Point operator -(Point a, Point b)
        {
            return new Point((a.X - b.X), (a.Y - b.Y));
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Point pkt1 = new Point(3, 4);
            Console.WriteLine(pkt1);
            Point pkt2 = new Point(3, 5);
            Console.WriteLine(pkt2);

            Console.WriteLine(pkt1 == pkt2);
            Console.WriteLine(pkt1 + pkt2);
            Console.WriteLine(pkt1 - pkt2);
        }
    }
}
