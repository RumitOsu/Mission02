using System;

namespace DiceRollSim
{
    // Main class
    class Program
    {   
        static void Main(string[] args)
        {
            // Asking for the number of rolls from the user and saving it
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            int iRolls = Convert.ToInt32(Console.ReadLine());

            // Creating an instance of the DiceRoll class then getting the results from it
            DiceRoll roller = new DiceRoll();
            int[] results = roller.RollDices(iRolls);

            // Display the results in console
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {iRolls}.");

            // looping through the results and creating a histogram
            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{i}: ");
                Console.WriteLine(new string('*', results[i - 2] * 100 / iRolls));
            }
            // final message before exiting
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}

