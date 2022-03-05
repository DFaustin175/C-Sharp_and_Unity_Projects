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
                Console.WriteLine(stringArray[i]);
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
            for( int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine(stringList[i]);
                if(stringList[i] == nameInput)
                {
                    Console.WriteLine(i);
                    break;    
                }
                else if(i == 6)
                {
                    Console.WriteLine("Name not found");
                }
            }
            Console.ReadLine();

            List<string> stringList2 = new List<string>();
            stringList2.Add("Tom");
            stringList2.Add("Cory");
            stringList2.Add("Ben");
            stringList2.Add("Cory");
            stringList2.Add("Tom");
            stringList2.Add("Brad");
            Console.WriteLine("Input name: ");
            string nameInput2 = Console.ReadLine();
            for(int i = 0; i < stringList2.Count; i++)
            {
                if (stringList2[i] == nameInput2)
                {
                    Console.Write(stringList2[i]);
                }
                else if (i == stringList2.Count)
                {
                    Console.WriteLine("Name not found");
                }
            }
            Console.ReadLine();

            var names = new List<string>() { "John", "Tom", "Peter", "John", "Tom", "Peter" };
            int john = 0, tom = 0, peter = 0;
            foreach (string name in names)
            {
                if (name == "John")
                {
                    john++;
                }
                else if (name == "Tom")
                {
                    tom++;
                }
                else if (name == "Peter")
                {
                    peter++;
                }
            }
            Console.WriteLine("Number of Johns = {0}", john);
            Console.WriteLine("Number of Toms = {0}", tom);
            Console.WriteLine("Number of Peter = {0}", peter);
            Console.ReadLine();

        }
    }
}
