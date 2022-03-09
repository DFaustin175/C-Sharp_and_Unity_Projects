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
            Class1.Add(userInput);
            Console.ReadLine();
            Console.WriteLine("Enter another integer");
            float userInput2 = float.Parse(Console.ReadLine());
            Class1.Div(userInput2);
            Console.ReadLine();
            Console.WriteLine("Enter one more integer");
            string userInput3 = Console.ReadLine();
            Class1.Sub(userInput3);
            Console.ReadLine();

        }
    }
}
