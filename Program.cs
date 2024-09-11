using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("You are now playing Rock Paper scissor");
            Console.ReadKey();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Enter your move: Rock, Paper, or scissor";

            // Pmove is the person's move in the game.
            string Pmove = Console.ReadLine().ToLower();

            // Cmove is the computer's move in the game.
            Random random = new Random();
            string[] moves = { "rock", "paper", "scissor" };
            string Cmove = moves[random.Next(moves.Length)];


            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nComputerens move was");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n"+ Cmove);

            // The result giver of the game.
            if (Pmove == Cmove)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("It was a Tie! Do it again!");
            }
            else if (Pmove == "scissor" && Cmove == "paper" ||
                     Pmove == "paper" && Cmove == "rock" ||
                     Pmove == "rock" && Cmove == "scissor")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("You Win!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("You Lost!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.White;
            }
        }
    }
}
