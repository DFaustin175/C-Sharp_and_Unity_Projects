using System;

namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is " + yourName);
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your Course is " + yourCourse);
            Console.WriteLine("What page are you on?");
            string pageNum = Console.ReadLine();
            int page = Convert.ToInt16(pageNum);
            Console.WriteLine("You are on page " + page);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            bool needsHelp = true;
            if (needsHelp)
            {
                Console.WriteLine("Someone will be able to help you shortly!");
            }
            else
            {
                Console.WriteLine("Glad to hear it!");
            }
            Console.WriteLine(needsHelp);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string exp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hours = Convert.ToInt16(hoursStudied);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
