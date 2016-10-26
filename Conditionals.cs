using System;
using System.Linq;

namespace LearningCSharp
{
    public class Conditionals
    {
        public static void Main()
        {
            // Enter number print if it is positive or negative
            Console.WriteLine("Entering Method PositiveOrNegative()");
            PositiveOrNegative();

            // Provide year check if it is a leap year
            Console.WriteLine("Entering Method CheckIfLeapYear()");
            CheckIfLeapYear();
        }

        public static void PositiveOrNegative()
        {
            Console.WriteLine("Enter number: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            if (inputNum < 0)
            {
                Console.WriteLine("Number is negative");
            }

            else
            {
                Console.WriteLine("Number is positive");
            }
        }

        public static void CheckIfLeapYear()
        {
            Console.WriteLine("Check if a year is a leap year or not.");
            Console.WriteLine("Enter Year in 4 digit format - xxxx: ");
            int inputYear = Convert.ToInt32(Console.ReadLine());

            if (Convert.ToString(inputYear).Length != 4)
            {
                Console.WriteLine("The provided year is in incorrect format. It should be respesented with 4 digits - ex. 2016");
                CheckIfLeapYear();
            }

            if (DateTime.IsLeapYear(inputYear))
            {
                Console.WriteLine("{0} is a leap year", inputYear);
            }

            else
            {
                Console.WriteLine("{0} is Not a leap year", inputYear);
            }
        }
    }
}