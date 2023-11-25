

using System;

namespace Game
{


    class Program
    {

        static void Main(string[] args)
        {

            Random random = new Random();

            Console.WriteLine("Welcome to the Rock Paper Scissors Game!!");
            Console.WriteLine("Enter 'r' for Rock, 'p' for Paper, 's' to Scissors");
            string? input = Console.ReadLine();

            int enemyChoice = random.Next(0, 3);

            if(input != null)
            {
                playGame(enemyChoice, input);
            }
            
        }

        private static void playGame(int enemyChoice, string input)
        {
            if (enemyChoice == 0)
            {

                Console.WriteLine("enemy chooses rock");
                switch (input)
                {
                    case "r":
                        Console.WriteLine("Tie");
                        break;
                    case "s":
                        Console.WriteLine("You lose");
                        break;
                    case "p":
                        Console.WriteLine("You win");
                        break;
                }
            }
            else if (enemyChoice == 1)
            {
                Console.WriteLine("enemy chooses paper");
                switch (input)
                {
                    case "r":
                        Console.WriteLine("You lose");
                        break;
                    case "s":
                        Console.WriteLine("You win");
                        break;
                    case "p":
                        Console.WriteLine("Tie");
                        break;
                }
            }
            else
            {
                Console.WriteLine("enemy chooses scissors");
                switch (input)
                {
                    case "r":
                        Console.WriteLine("You win");
                        break;
                    case "s":
                        Console.WriteLine("Tie");
                        break;
                    case "p":
                        Console.WriteLine("You lose");
                        break;
                }
            }
        }
    }
}
