using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Calling
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an Integer");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int result1 = Class1.Add(userInput);
            Console.WriteLine(result1);
            Console.ReadLine();

            
            Console.WriteLine("Enter another integer");
            decimal userInput2 = Convert.ToDecimal(Console.ReadLine());
            int result2 = Class1.Div(userInput2);
            Console.WriteLine(result2);
            Console.ReadLine();


            Console.WriteLine("Enter one more integer");
            string userInput3 = Console.ReadLine();
            int result3 = Class1.Sub(userInput3);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}
