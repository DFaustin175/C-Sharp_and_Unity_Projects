using System;

namespace Car_Insurance_Approval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int personAge = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI?");
            string duiAnswer = Console.ReadLine();
            bool DUI = System.Convert.ToBoolean(duiAnswer);
            Console.WriteLine("How many speeding tickets do you have?");
            string speedTick = Console.ReadLine();
            int ticketCount = Convert.ToInt32(speedTick);
            bool qualify = (personAge >= 15 && !DUI && ticketCount <= 3);
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualify);
            Console.ReadLine();
        }
    }
}
