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
            string userInput = Console.ReadLine();
            Console.WriteLine("Enter second integer (not needed)");
            string userInput2 = Console.ReadLine();
            if (userInput2 == "") Console.WriteLine("No second integer found");
            Class1.DoubleInt(userInput, userInput2);
            Console.ReadLine();
        }
    }
}
