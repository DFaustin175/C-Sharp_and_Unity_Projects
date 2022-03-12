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
            IQuittable quittable = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();
            quittable.Quit();
            Console.ReadLine();
        }
    }
}
