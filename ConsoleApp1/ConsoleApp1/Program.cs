using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp1
{
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds( seconds );
            int tHours;
            int hours = seconds / 3600;
            if (hours > 0)
                {
                    tHours = hours;
                }
            else
                {
                    tHours = t.Hours;
            }
            return String.Format("{0:D2}:{1:D2}:{2:D2}", tHours, t.Minutes, t.Seconds);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(TimeFormat.GetReadableTime(359999));

            Console.ReadKey();
        }
    }
}
