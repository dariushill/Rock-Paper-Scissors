using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to rock paper scissors! ");

            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Player score - " + playerScore + ". Enemy Score - " + enemyScore);

                // Player turn
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper, and 's' for scissors");
                string playerChoice = Console.ReadLine();

                // Enemy turn
                int enemyChoice = random.Next(0, 3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy choices rock.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie");
                            break;
                        case "p":
                            Console.WriteLine("Player won!");
                            playerScore += 1;
                            break;
                        case "s":
                            Console.WriteLine("Enemy Won");
                            enemyScore += 1;
                            break;
                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy choices paper.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy Won");
                            enemyScore += 1;
                            break;
                        case "p":
                            Console.WriteLine("Tied");
                            break;
                        case "s":
                            Console.WriteLine("Player won");
                            playerScore += 1;
                            break;
                    }
                }
                else if (enemyChoice == 2)
                {
                    Console.WriteLine("Enemy choices scissors.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player won");
                            playerScore += 1;
                            break;
                        case "p":
                            Console.WriteLine("Enemy won");
                            enemyScore += 1;
                            break;
                        case "s":
                            Console.WriteLine("Tied");
                            break;
                    }
                }

                if (playerScore == 3)
                {
                    Console.WriteLine("You won");
                }
                else if (enemyScore == 3)
                {
                    Console.WriteLine("You lose");
                }
            }
        }
    }
}
