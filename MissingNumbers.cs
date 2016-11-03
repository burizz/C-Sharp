using System;
using System.Collections.Generic;
using System.Linq;

// Compare two strings of numbers and print the numbers that are missing from inputLineN
// i.e. :
// inputLineN = 203 204 205 206 207 208 203 204 205 206
// inputLineM = 203 204 204 205 206 207 205 208 203 206 205 206 204

namespace HackerRank
{
    class MainClass
    {
        static void Main(String[] args)
        {
            // Build Array N from input numbers
            Console.ReadLine();
            string[] numbersN = Console.ReadLine().Split();

            // Build Array M from second input numbers
            Console.ReadLine();
            string[] numbersM = Console.ReadLine().Split();
            
            var missingNumbers = new List<string>();

            foreach (string num in numbersM.Distinct())
            {
                int difference = numbersM.Where(x => x == num).Count() - numbersN.Where(x => x == num).Count();
                for (int i = difference; i > 0; i--)
                {
                    missingNumbers.Add(num);
                }
            }

            // Sort missing items and join them back in a single string
            missingNumbers.Sort();
            string[] removeDuplicates = missingNumbers.Distinct().ToArray();
            string stringOfNumbers = string.Join(" ", removeDuplicates);

            Console.WriteLine(stringOfNumbers);
        }
    }
}
