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
            Console.WriteLine(Class1.a1);
            Console.ReadLine();
            Console.WriteLine("Enter another integer");
            decimal userInput2 = Convert.ToDecimal(Console.ReadLine());
            Class1.Div(userInput2);
            Console.WriteLine(Class1.b1);
            Console.ReadLine();
            Console.WriteLine("Enter one more integer");
            string userInput3 = Console.ReadLine();
            Class1.Sub(userInput3);
            Console.WriteLine(Class1.c1);
            Console.ReadLine();
        }
    }
}
