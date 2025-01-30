using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;

            Console.WriteLine("Welcome to the temperature converter\n");
            Console.WriteLine("Are you looking for convert from F > C?\n");
            Console.WriteLine("Press y for yes or n for no.\n");

            string x = Console.ReadLine();

            if (x == "y" )
            {
                Console.WriteLine("Enter the temperature in degrees Fahrenheit\n");
                string str_F = Console.ReadLine();
                F = Convert.ToDouble(str_F);
                C = (F - 32) * 5 / 9;
                Console.WriteLine("It is " + C.ToString() + " degrees in Celsius.\n");
                Console.WriteLine("Conversion is complete\n");
            }
            else if (x == "n" )
            {
                Console.WriteLine("Enter the temperature in degrees Celsius\n");
                string str_C = Console.ReadLine();
                C = Convert.ToDouble(str_C);
                F = (C * 9 / 5) + 32;
                Console.WriteLine("It is " + F.ToString() + " degrees in Fahrenheit.\n");
                Console.WriteLine("Conversion is complete\n");
            }
            else
            {
                Console.WriteLine("Please select y or n. Program Ended.");
            }

        }
    }
}