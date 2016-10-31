using System;
using System.Collections.Generic;
using System.Linq;

// Compare two strings of numbers and print the numbers that are missing from inputLineN
// inputLineN = 203 204 205 206 207 208 203 204 205 206
// inputLineM = 203 204 204 205 206 207 205 208 203 206 205 206 204

namespace HackerRank
{
	class MainClass
	{
		static void Main(String[] args)
		{
			// Build Array N from input numbers
			string[] inputLineN = Console.ReadLine().Split();

			// Build Array M from second input numbers
			string[] inputLineM = Console.ReadLine().Split();

			// Convert to int[] array
			int[] numbersN = Array.ConvertAll(inputLineN, int.Parse);
			int[] numbersM = Array.ConvertAll(inputLineM, int.Parse);

			// Convert them to Lists
			var listN = new List<int>(numbersN);
			var listM = new List<int>(numbersM);

			for (int index = 0; index < listN.Count; index++)
			{
				// Remove first occurance of item from listM if it exists in listN
				if (listM.Remove(listN[index]))
				{
					// Remove listN[index] and decrement the index to -1 so that the next iteration
                    			// starts from 0 again otherwise we will start at 1 and skip an item
					listN.RemoveAt(index--);
				}
			}

			// Sort missing items and join them back in a single string
			listM.Sort();
			int[] removeDuplicates = listM.Distinct().ToArray();
			string missingNumbers = string.Join(" ", removeDuplicates);

			Console.WriteLine(missingNumbers);
		}
	}
}
