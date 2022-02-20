using System;

namespace Shipping_Quote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Input package weight:");
            string packageWeight = Console.ReadLine();
            int weight = Convert.ToInt32(packageWeight);
            if (weight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }
            else if (weight < 50)
            {
                Console.WriteLine("Input package width");
                string width = Console.ReadLine();
                int packageWidth = Convert.ToInt32(width);
                Console.WriteLine("Input package height");
                string height = Console.ReadLine();
                int packageHeight = Convert.ToInt32(height);
                Console.WriteLine("Input package length");
                string length = Console.ReadLine();
                int packageLength = Convert.ToInt32(length);
                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                    Console.ReadLine();
                }
                else
                {
                    int packageTotal = packageWidth * packageHeight * packageLength;
                    packageTotal = packageTotal * weight;
                    packageTotal = packageTotal / 100;
                    string Total = Convert.ToString(packageTotal);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + Total);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
