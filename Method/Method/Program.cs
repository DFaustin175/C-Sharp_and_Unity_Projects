using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first integer");
            int userInput = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second integer (not needed)");
            string userInput2 = Console.ReadLine();
            if (userInput2 == "")
            {
                Console.WriteLine("No second integer found");
                int result = Class1.DoubleInt(userInput);
                Console.WriteLine(result);
            } 
            else
            {
                int userInput2Int = Convert.ToInt32(userInput2);
                int result2 = Class1.DoubleInt(userInput, userInput2Int);
                Console.WriteLine(result2);
            }
            
            Console.ReadLine();
        }
    }
}
