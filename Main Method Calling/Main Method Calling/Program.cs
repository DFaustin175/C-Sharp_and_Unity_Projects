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
            Class1 mathProbs = new Class1();
            Console.WriteLine("Enter an Integer");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mathProbs.Add(userInput));
            Console.ReadLine();

            
            Console.WriteLine("Enter a decimal number");
            decimal userInput2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(mathProbs.Div(userInput2));
            Console.ReadLine();


            Console.WriteLine("Enter one more integer");
            string userInput3 = Console.ReadLine();
            Console.WriteLine(mathProbs.Sub(userInput3));
            Console.ReadLine();
        }
    }
}
