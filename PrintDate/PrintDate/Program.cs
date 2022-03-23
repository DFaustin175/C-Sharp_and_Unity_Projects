using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDate
{
    internal class Program
    {
        static void Main()
        {
            //Prints current date and time to console
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            //Ask the user for a number
            Console.WriteLine("Input a whole number");
            var userinput = Convert.ToDouble(Console.ReadLine());
            

            var answer = now.AddHours(userinput);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
