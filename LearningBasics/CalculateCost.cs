using System;

namespace HackerRank
{
    class CalculateCost
    {   
        public static void Main(String[] args)
            {
            double costOfMeal = Convert.ToDouble(Console.ReadLine());
            int percentTip = Convert.ToInt32(Console.ReadLine());
            int percentTax = Convert.ToInt32(Console.ReadLine());
            
            // Console.WriteLine("Cost of Meal: {0}, Percent Tip: {1}, Percent Tax: {2}", costOfMeal, percentTip, percentTax);

            double calculateTip = ((double)percentTip / 100) * costOfMeal;
            double caltulateTax = ((double)percentTax / 100) * costOfMeal;
            int totalCost = Convert.ToInt32(costOfMeal + calculateTip + caltulateTax);

            // Console.WriteLine("Percent Tip : {0}, Perecent Tax : {1}", calculateTip, caltulateTax);
            
            Console.WriteLine("The total meal cost is {0} dollars.", totalCost);
            }
    }
}
