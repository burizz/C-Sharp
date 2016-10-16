using System;
using System.Linq;

namespace LearningCSharp
{
    public class BasicExercise
    {
        public static int Add(int addOne, int addTwo)
        // Add two numbers
        {
            return addOne + addTwo;
        }

        public static int Devide(int devideNumOne, int devideNumTwo)
        // Devide two numbers
        {
            return devideNumOne / devideNumTwo;
        }

        public static int[] SwapNumbers(int[] twoNumbers)
        // Swap two numbers
        {
            Array.Reverse(twoNumbers);
            return twoNumbers;
        }

        public static int MultiplyThreeNums(int[] arrayOfThreeInts)
        // Multiply three numbers
        {
            int result = arrayOfThreeInts[0] * arrayOfThreeInts[1] * arrayOfThreeInts[2];

            return result;
        }

        public static void MultiplyThreeNums()
        // Another implementation of the same MultiplyThreeNums method
        {
            Console.WriteLine("Input the first number to multiply: ");
            int numOne = Convert.ToInt32(Console.ReadKey());

            Console.WriteLine("Input the second number to multiply: ");
            int numTwo = Convert.ToInt32(Console.ReadKey());

            Console.WriteLine("Input the third number to multiply: ");
            int numThree = Convert.ToInt32(Console.ReadKey());

            int result = numOne * numTwo * numThree;

            Console.WriteLine("Output: {0} x {1} x {2} = {3}", numOne, numTwo, numThree, result);
        }

        public static void PrintExprOfTwoNumbers(int numOne, int numTwo)
        //  Print the output of adding, subtracting, multiplying and dividing of two numbers
        {
            int addedNums = numOne + numTwo;
            int subtractedNums = numOne - numTwo;
            int multipliedNums = numOne * numTwo;
            int devidedNums = numOne / numTwo;
            int leftoverNum = numOne % numTwo;

            Console.WriteLine("Addition : " + addedNums);
            Console.WriteLine("Subtraction : " + subtractedNums);
            Console.WriteLine("Multiplication : " + multipliedNums);
            Console.WriteLine("Devision : " + devidedNums);
            Console.WriteLine("Modulo left-over : " + leftoverNum);
        }

        public static void MultiplicationTable(int numToMultiply)
        // Print multiplication table of a number
        {
            for (int multiplier = 1; multiplier <= 10; multiplier++)
            {
                Console.WriteLine(numToMultiply * multiplier);
            }
        }

        public static void CalculateAverage(int[] numArrayForAverage)
        // Calculate average of array of INTs
        {
            int average = numArrayForAverage.Sum() / numArrayForAverage.Length;
            string arrayValues = string.Join(",", numArrayForAverage);

            Console.WriteLine("The average of {0} is: {1}", arrayValues, average);
        }

        public static void ConvertCeliusToKelvOrFahr(int degreesCelsius)
        // Convert Celsius to Kelvin and Fahrenheit
        {
            double degreesKelvin = 273.15 + degreesCelsius;
            double degreesFahrenheit = degreesCelsius * 1.8 + 32;

            Console.WriteLine("{0} degrees Celsius is {1} Kelvin and {2} Fahrenheit", degreesCelsius, degreesKelvin, degreesFahrenheit);
        }
    }
}
