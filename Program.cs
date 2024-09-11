using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Welcome to the guessing game UUUUUAAAAAAA!");


            Random random = new Random();
            int Rnumber = random.Next(1, 2);
            int guess = 0;
            int attempts = 0;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("I have a number between 1 and 25. Can you guess it?");

            while (guess != Rnumber)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;
            }


           

            if (guess == Rnumber)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congrats on the WIN!");
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("The number was:{0}", Rnumber);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("It took you {0} attempts", attempts);
                Console.ForegroundColor = ConsoleColor.Black;
            }
            }
        }
    }
}
