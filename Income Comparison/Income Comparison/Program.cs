using System;

namespace Income_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            string Rate1 = Console.ReadLine();
            float person1Rate = float.Parse(Rate1);
            Console.WriteLine("Hours worked per week?:");
            string hours = Console.ReadLine();
            int person1Hours = Int32.Parse(hours);
            Console.WriteLine("Person 2");
            Console.WriteLine("Person 2 Hourly Rate:");
            string Rate2 = Console.ReadLine();
            float person2Rate = float.Parse(Rate2);
            Console.WriteLine("Person 2 Hours worked per week?:");
            string hours2 = Console.ReadLine();
            int person2Hours = Int32.Parse(hours2);
            float annual1 = person1Rate * person1Hours * 52;
            float annual2 = person2Rate * person2Hours * 52;
            Console.WriteLine("Annual salary of Person 1: " + annual1);
            Console.WriteLine("Annual salary of Person 2: " + annual2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool greaterSalary = annual1 > annual2;
            Console.WriteLine(greaterSalary);
            Console.ReadLine();
        }
    }
}
