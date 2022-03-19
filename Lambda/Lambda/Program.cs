using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Program
    {
        static void Main()
        {
            List<empInfo> Employees = new List<empInfo>()
            {
                new empInfo { Name = "Joe", LName = "Benedict ", ID = 1 },
                new empInfo { Name = "Cory", LName = "Maxwell ", ID = 2 },
                new empInfo { Name = "Jane", LName = "Doe ", ID = 3 },
                new empInfo { Name = "John", LName = "Doe ", ID = 4 },
                new empInfo { Name = "Ethan", LName = "Winters ", ID = 5 },
                new empInfo { Name = "Joe", LName = "Hughjass ", ID = 6 },
                new empInfo { Name = "Joe", LName = "Slapyason ", ID = 7 },
                new empInfo { Name = "Finn", LName = "Johnson ", ID = 8 },
                new empInfo { Name = "Connor", LName = "Benson ", ID = 9 },
                new empInfo { Name = "Ryan", LName = "Williams ", ID = 10 }
            };

            foreach(empInfo emp in Employees)
            {
                if(emp.Name == "Joe")
                {
                    Console.WriteLine("First Name: " + emp.Name + " Last Name: " + emp.LName + "Employee ID: " + emp.ID);
                }
            }
            Console.ReadLine();

            var empJoe =
                from emp in Employees
                where emp.Name == "Joe"
                select emp;
            foreach (var emp in empJoe)
            {
                Console.WriteLine("First Name: " + emp.Name + " Last Name: " + emp.LName + "Employee ID: " + emp.ID);
            }
            Console.ReadLine();

            var IDGreater5 =
                from emp in Employees
                where emp.ID > 5
                select emp;

            foreach(var emp in IDGreater5)
            {
                Console.WriteLine("First Name: " + emp.Name + " Last Name: " + emp.LName + "Employee ID: " + emp.ID);
            }
            Console.ReadLine();

        }
    }
}
