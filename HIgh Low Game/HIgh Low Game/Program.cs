using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIgh_Low_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                //Display welcome message
                Console.WriteLine("Welcome to the High Low Game");

                //Random number generator
                Random rng = new Random();
                int number = rng.Next(1, 11);

                //Tries counter
                int tries = 0;

                //While Loop
                while (true)
                {

                    //User enters guess
                    Console.Write("Enter your guess: ");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    //Comparing the guess against number
                    if (guess < number)
                    {
                        Console.WriteLine("Too low");
                        tries = tries + 1;
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Too high");
                        tries = tries + 1;
                    }
                    else
                    {
                        Console.WriteLine("Well Done. You guessed the correct number");
                        tries = tries + 1;
                        Console.WriteLine("You did it in " + tries + " tries");
                        break;
                    }
                }

                

                //Play again
                Console.WriteLine("Would you like to play again");
                string again = Console.ReadLine();
                if (again == "no")
                {
                    break;
                }
                else
                {
                    continue;
                }
                //Wait for key press
                Console.ReadKey();
            }
        }
    }
}
