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
            list1.things("Thing");
            list1.things("Thing1");
            list1.things("Thing2");
            list1.things("Thing3");

            Employee<int> list2 = new Employee<int>();
            list2.things(1);
            list2.things(2);
            list2.things(3);
            list2.things(4);
            list2.things(5);

            for (int i = 0; i < list1.Length; i++)
            {
                Console.WriteLine("things");
            }
                
            Console.ReadLine();

        }
    }
}
