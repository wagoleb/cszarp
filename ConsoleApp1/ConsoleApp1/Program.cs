using System;
using System.Collections;
using System.Linq;


namespace ConsoleApp1
{
    public class NumberTranslation
    {


        public static string Number2Words(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + Number2Words(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += Number2Words(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += Number2Words(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += Number2Words(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += " ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words.TrimEnd();
        }


    }

    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(NumberTranslation.Number2Words(800));
        }
    }
}
