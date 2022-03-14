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
            employee.Id = 12;
            employee.SayName();

            Employee employee2 = new Employee();
            Console.WriteLine("Please input First and Last Name");
            employee2.FirstName = "Sample";
            employee2.LastName = "Student2";
            employee.Id = 18;
            employee2.SayName();
            Console.ReadLine();

        }
    }
}
