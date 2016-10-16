using System;
using BasicExercise;
using DataTypePractice;

namespace LearningCSharp
{
    public class ExerciseMain
    {
        public static void Main(string[] args)
        {
            // Add two numbers
            int addOne = 8;
            int addTwo = 2;
            Console.WriteLine(Add(addOne, addTwo));

            // Devide two numbers
            Console.WriteLine(Devide(addOne, addTwo));

            // Reversed numbers
            int[] initialTwoNumbers = new int[] { 5, 6 };
            int[] reversedNumbers = SwapNumbers(initialTwoNumbers);

            Console.WriteLine("First Number : " + reversedNumbers[0]);
            Console.WriteLine("Second Number : " + reversedNumbers[1]);

            // Multiply three numbers
            int[] intsToMultiply = new int[] { 2, 3, 6 };
            Console.WriteLine(MultiplyThreeNums(intsToMultiply));

            // Another implementation of the same MultiplyThreeNums method
            MultiplyThreeNums();

            // PrintExprOfTwoNumbers())
            Console.Write("Enter a number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            PrintExprOfTwoNumbers(firstNumber, secondNumber);

            // Print Multiplication table of a number - MultiplicationTable()
            Console.WriteLine("Enter number bellow to see it's multiplication table");
            Console.WriteLine("Number: ");
            int multiplicationTableofNum = Convert.ToInt32(Console.ReadLine());

            MultiplicationTable(multiplicationTableofNum);

            // CalculateAverage(int[])
            int[] arrayOfNumsForAverage = new int[] { 10, 15, 20, 30 };
            CalculateAverage(arrayOfNumsForAverage);

            // Convert Celsius to Fahrenheit and Kelvin
            ConvertCeliusToKelvOrFahr(-30);

            // Take number and width, print triangle of that width using that number
            TriangleOfWidth(3, 20);

            // Take two numbers and expression and print result
            evalExpression(20, "-", 12);

            // Take radius and return perimeter and area (circumference)
            CalcPerimeterAndAreaOfCircle();

            // Prompt for user and pass, return 3 different cases if they match and if they do not
            LoginUserAndPass();

            // Enter two of distance, speed, or time and find the other
            CalculateDistanceTimeSpeed();
        }
    }
}
