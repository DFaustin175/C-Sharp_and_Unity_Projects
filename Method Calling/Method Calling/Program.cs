using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Calling
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int numInput = Convert.ToInt32(Console.ReadLine());
            Class1.Add(numInput);
            Class1.Mult(numInput);
            Class1.Sub(numInput);
            Console.ReadLine();
        }
    }
}
