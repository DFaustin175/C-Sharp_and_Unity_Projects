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
            Console.WriteLine("You are on page " + pageNum);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            string answer = Console.ReadLine();
            if (answer == "true")
            {
                Console.WriteLine("What topic do you need help with?");
                string problem = Console.ReadLine();
                Console.WriteLine("Ok someone will be able to help you with " + problem);
            }
            else if (answer == "false")
            {
                Console.WriteLine("Glad to hear it!");
                
            }
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string exp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
