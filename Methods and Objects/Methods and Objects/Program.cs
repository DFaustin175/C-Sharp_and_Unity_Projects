﻿using System;
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
            employee.FirstName = Console.ReadLine();
            employee.LastName = Console.ReadLine();

            employee.SayName();
            Console.ReadLine();

        }
    }
}