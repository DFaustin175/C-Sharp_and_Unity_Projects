using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter first name");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            employee.LastName = Console.ReadLine();
            employee.SayName();
            Console.ReadLine();
            employee.Quit();
            Console.ReadLine();
        }
    }
}
