using System;

namespace WhileLoops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("While Satement");
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            while (!isGuessed)
            {
                switch (number)
                {
                    case 12:
                        Console.WriteLine("You guessed correctly");
                        Console.ReadLine();
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            Console.WriteLine("Enter password");
            string correctPassword = "sandwich";
            string passwordAttempt = Console.ReadLine();

            do
            {
                Console.WriteLine("Password incorrect");
                passwordAttempt = Console.ReadLine();
            }
            while (correctPassword != passwordAttempt);
            Console.WriteLine("Password accepted");
            Console.ReadLine();
        }
    }
}
