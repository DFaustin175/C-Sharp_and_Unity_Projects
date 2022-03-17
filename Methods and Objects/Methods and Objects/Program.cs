using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    internal class Program
    {
        static void Main()
        {
            
            Employee<string> employee = new Employee<string>();
            Console.WriteLine("Please input First and Last Name");
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 18;
            employee.SayName();

            Employee<string> employee2 = new Employee<string>();
            Console.WriteLine("Please input First and Last Name");
            employee2.FirstName = "Sample";
            employee2.LastName = "Student2";
            employee2.Id = 18;
            employee2.SayName();

            if (employee2.Id == employee.Id)
                Console.WriteLine("Same ID");
            else Console.WriteLine("Different ID");

            Employee<string> list1 = new Employee<string>();
            list1.things = new List<string>();
            list1.things.Add("Thing");
            list1.things.Add("Thing1");
            list1.things.Add("Thing2");
            list1.things.Add("Thing3");

            Employee<int> List2 = new Employee<int>();
            List2.things = new List<int>();
            List2.things.Add(1);
            List2.things.Add(2);
            List2.things.Add(3);
            List2.things.Add(4);
            List2.things.Add(5);

            for (int i = 0; i < list1.things.Count; i++)
            {
                Console.WriteLine(list1.things[i]);
            }

            for (int i = 0; i < List2.things.Count; i++)
            {
                Console.WriteLine(List2.things[i]);
            }

            Console.ReadLine();

        }
    }
}
