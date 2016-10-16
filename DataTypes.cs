using System;
using System.Linq;

namespace LearningCSharp
{
    public class DataTypePractice
    {
        public static void TriangleOfWidth(int inputNumber, int widthNumber)
        // Take number and width, print triangle of that width using that number
        {
            for (int index = widthNumber; index >= 0; index--)
            {
                string triangle = inputNumber.ToString();
                Console.WriteLine(String.Concat(Enumerable.Repeat(triangle, index)));
            }
        }

        public static void evalExpression(int numOne, string exprsnOperator, int numTwo)
        // Take two numbers and expression and print result
        {
            if (exprsnOperator == "+")
            {
                Console.WriteLine(numOne + numTwo);
            }

            else if (exprsnOperator == "-")
            {
                Console.WriteLine(numOne - numTwo);
            }

            else if (exprsnOperator == "*")
            {
                Console.WriteLine(numOne * numTwo);
            }

            else if (exprsnOperator == "/")
            {
                Console.WriteLine(numOne / numTwo);
            }

            else
            {
                Console.WriteLine("Invalid Operator - {0}", exprsnOperator);
            }

        }

        public static void CalcPerimeterAndAreaOfCircle()
        // Take radius and return perimeter and area (circumference)
        {
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double area = 2 * pi * radius;
            Console.WriteLine("The Perimeter or Circumference (C=2πr) of your circle is: {0:F2}", area);
        }

        public static void LoginUserAndPass()
        // Take user and pass after three failed attempts reject user
        {
            string userName, passWord;
            string correctUser = "buriz";
            string correctPass = "1234";

            int loginAttemptCounter = 0;

            do
            {
                Console.WriteLine("Enter User Name : ");
                userName = Console.ReadLine();

                Console.WriteLine("Enter Password : ");
                passWord = Console.ReadLine();

                loginAttemptCounter++;
            }

            while ((userName != correctUser && passWord != correctPass)
                && (loginAttemptCounter < 3));

            if (loginAttemptCounter == 3)
            {
                Console.WriteLine("Login failed three consecutive times. Exiting ... ");
            }

            else if (userName == correctUser && passWord == correctPass)
            {
                Console.WriteLine("Login successful - User: {0}", userName);
            }

            else
            {
                Console.WriteLine("Login Failed. Please Try again.");
            }
        }

        
        public static void CalculateDistanceTimeSpeed()
        // Enter two of distance, speed, or time and find the other
        {
            float speed;
            float distance;
            float time;

            Console.WriteLine("Find distance/speed/time based on any of the two.");
            Console.WriteLine("Enter two of the three requirements");
            Console.WriteLine();

            Console.WriteLine("Enter speed in km/h");
            if (!Single.TryParse(Console.ReadLine(), out speed))
                speed = 0f;

            Console.WriteLine("Enter distance in km");
            if (!Single.TryParse(Console.ReadLine(), out distance))
                distance = 0f;

            Console.WriteLine("Enter time in hour/s");
            if (!Single.TryParse(Console.ReadLine(), out time))
                time = 0f;

            if (speed == 0f)
            {
                speed = distance / time;
                Console.WriteLine("Required average Speed : {1}km/h for distance {0}km and time {2}hrs.", distance, speed.ToString("0.##"), time);
            }

            else if (distance == 0f)
            {
                distance = speed * time;
                Console.WriteLine("Distance traveled : {0}km at speed {1}km/h for {2}hrs.", distance.ToString("0.##"), speed, time);

            }

            else
            {
                time = distance / speed;
                Console.WriteLine("Travel time: {2}hrs with speed {1}km/h for distance {0}km.", distance, speed, time.ToString("0.##"));
            }
        }

        public static void CheckCharType()
        {
            // Take char, check input (lowercase) is a vowel, digit, symbol
            // islower()

            Console.WriteLine("Enter a single character :");
            string inputChar = Console.ReadLine();

            if (inputChar.Any(char.IsDigit))
            {
                Console.WriteLine("Input char is a digit");
            }

            else if (inputChar.Any(char.IsSymbol))
            {
                Console.WriteLine("Input char is a Symbol");
            }

            else
            {
                Console.WriteLine("Input char is a letter");
            }
        }
    }
}