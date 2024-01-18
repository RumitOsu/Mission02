using System;

namespace DiceRollSim
{
    // class for rolling the dice
    public class DiceRoll
    {
        //random number generator
        private Random random = new Random();
        
        // rolling the dices user input amount of times
        public int[] RollDices(int iRolls)
        {
            // track score with an array with 11 slots for each result (2 - 12).
            int[] results = new int[11];

            // loop through amount of times dice needs to be rolled 
            for (int i = 0; i < iRolls; i++)
            {
                // rolling two dices and adding the results
                int rollOne = random.Next(1, 7);
                int rollTwo = random.Next(1, 7);
                int sum = rollOne + rollTwo;
                
                // matching the results to the array slots
                results[sum - 2]++;
            }

            // returning the array
            return results;
        }
    }
}
