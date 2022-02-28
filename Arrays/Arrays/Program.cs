using System;
using System.Collections;
using System.Collections.Generic;
namespace Arrays
{
    internal class Program
    {
        static void Main()
        {
            string[] names = { "Ryan", "Chris", "Brigid", "Sergi" };
            int nameInput = int.Parse(Console.ReadLine());
            if ( nameInput == 0 || nameInput == 1 || nameInput == 2 || nameInput == 3)
            {
                Console.WriteLine(names[nameInput]);
            }
            else 
            {
                Console.WriteLine("Error 404");
            }

            int[] nums = { 10, 32, 222, 790 };
            int numsInput = int.Parse(Console.ReadLine());
            if (numsInput == 0 || numsInput == 1 || numsInput == 2 || numsInput == 3)
            {
                Console.WriteLine(nums[numsInput]);
            }
            else
            {
                Console.WriteLine("Error 404");
            }
            Console.ReadLine();
        }
    }
}
