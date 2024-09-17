using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Welcome to the guessing game!");
            GuessingGame game = new GuessingGame();



            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("I have a number between 1 and 25. Can you guess it?");

            bool didIWin = false;
           

            while (didIWin == false)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                didIWin = game.MakeAGuess(guess);


                if (didIWin)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You guessed correctly!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("It took you {0} attempts", game.Attempt);
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You guessed wrong!");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
        }
    }
}


public class GuessingGame
{

    public int Attempt { get; private set; }
    public int Rnumber;
    public GuessingGame()
    {
        Attempt = 0;
        Random random = new Random();
        Rnumber = random.Next(1, 25);
    }

    public bool MakeAGuess(int PlayerGuess)
    {
        
        Attempt = Attempt+1;
        
        if (PlayerGuess == Rnumber)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
