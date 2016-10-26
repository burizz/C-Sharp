using System;
using System.Linq;

namespace LearningCSharp
{
    public class DataTypePractice
    {
        public static void Main()
        {
            // Take number and width, print triangle of that width using that number
            Console.WriteLine("On Method TriangleOfWidth");
            TriangleOfWidth(3, 20);
            
            // Take two numbers and expression and print result
            Console.WriteLine("On Method EvalExpression");
            EvalExpression(20, "-", 12);

            // Take radius and return perimeter and area (circumference)
            Console.WriteLine("On Method CalcPerimeterAndAreaOfCircle");
            CalcPerimeterAndAreaOfCircle();

            // Prompt for user and pass, return 3 different cases if they match and if they do not
            Console.WriteLine("On Method LoginUserAndPass");
            LoginUserAndPass();

            // Enter two of distance, speed, or time and find the other
            Console.WriteLine("On Method CalculateDistanceTimeSpeed");
            CalculateDistanceTimeSpeed();
            
            // Enter a char print the type of the char - vowel, digit, etc
            Console.WriteLine("On Method CheckCharType");
            CheckCharType();
            
            // Enter two numbers print if Both numbers are even or odd
            Console.WriteLine("On Method EvenOrOdd");
            EvenOrOdd();
        }
        
        public static void TriangleOfWidth(int inputNumber, int widthNumber)
        // Take number and width, print triangle of that width using that number
        {
            for (int index = widthNumber; index >= 0; index--)
            {
                string triangle = inputNumber.ToString();
                Console.WriteLine(String.Concat(Enumerable.Repeat(triangle, index)));
            }
        }

        public static void EvalExpression(int numOne, string exprsnOperator, int numTwo)
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
            Console.WriteLine("Enter Radius value as a floating number: ");
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
            char symbol;
           
            Console.WriteLine("Input a symbol to be checked");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                (symbol == 'o') || (symbol == 'u'))
            {
                Console.WriteLine("It's a lower case vowel.");
            }

            else if ((symbol >= '0') && (symbol <= '9'))
            {
                Console.WriteLine("It's a digit.");
            }

            else
                Console.WriteLine("It's another symbol.");
        }

        public static void EvenOrOdd()
        {
            // Take two nums return True/False if BOTH are even or odd
            Console.WriteLine("Enter the first number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            if (numOne % 2 == 0 && numTwo % 2 == 0)
            {
                Console.WriteLine("Numbers are even");
            }

            else
            {
                Console.WriteLine("Numbers are odd");
            }
        }
    }
}
