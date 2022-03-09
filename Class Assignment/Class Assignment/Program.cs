using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            class1.Div(userInput);
            int sum1 = class1.Add(1, 4);
            int sum2 = class1.Add(2, 5, 7);

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.ReadLine();
        }
    }
}
