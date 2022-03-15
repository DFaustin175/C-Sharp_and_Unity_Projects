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
            Employee employee = new Employee();
            Console.WriteLine("Please input First and Last Name");
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 18;
            employee.SayName();

            Employee employee2 = new Employee();
            Console.WriteLine("Please input First and Last Name");
            employee2.FirstName = "Sample";
            employee2.LastName = "Student2";
            employee2.Id = 18;
            employee2.SayName();

            if (employee2.Id == employee.Id)
                Console.WriteLine("Same ID");
            else Console.WriteLine("Different ID");
            Console.ReadLine();

        }
    }
}
