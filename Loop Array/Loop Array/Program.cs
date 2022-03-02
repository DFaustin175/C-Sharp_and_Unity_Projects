using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Array
{
    internal class Program
    {
        static void Main()
        {
            string[] stringArray = { "Hello ", "How are you ", "Have a nice day " };
            string userInput = Console.ReadLine();
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i] + userInput);
            }
            Console.ReadLine();
            Console.WriteLine("Execute infinite loop?");
            string answer = Console.ReadLine();
            if (answer == "yes" || answer == "Yes")
            {
                while (true)
                {
                    Console.WriteLine("To infinity!");
                }

            }
            else if (answer == "no" || answer == "No")
            {
                Console.WriteLine("your loss");
                Console.ReadLine();
            }

            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.ReadLine();

            int k = 0;
            while (k <= 5)
            {
                Console.WriteLine(k);
                k++;
            }
            Console.ReadLine();

            List<string> stringList = new List<string>();
            stringList.Add("Tom");
            stringList.Add("Cory");
            stringList.Add("Ben");
            stringList.Add("Sam");
            stringList.Add("Chad");
            stringList.Add("Brad");
            Console.WriteLine("Input name: ");
            string nameInput = Console.ReadLine();
            int l = 0;
            while (nameInput != stringList[l])
            {
                ++l;
                Console.WriteLine(stringList[l]);
                if (l == 6)
                {
                    Console.WriteLine("Name not found");
                    break;
                }
            }

            List<string> stringList2 = new List<string>();
            stringList2.Add("Tom");
            stringList2.Add("Cory");
            stringList2.Add("Ben");
            stringList2.Add("Cory");
            stringList2.Add("Tom");
            stringList2.Add("Brad");
            Console.WriteLine("Input name: ");
            string nameInput2 = Console.ReadLine();
            int z = 0;
            while (nameInput2 != stringList2[z])
            {
                ++z;
                if (z == 6)
                {
                    Console.WriteLine("Name not found");
                    break;
                }
                else if (nameInput2 == stringList2[z])
                {
                    Console.WriteLine(stringList2[z]);
                }
            }

            var names = new List<string>() { "John", "Tom", "Peter", "John", "Tom", "Peter" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }
    }
}
