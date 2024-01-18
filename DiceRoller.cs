using System;

namespace DiceRollSimulator
{
    public class DiceRoller
    {
        private Random random = new Random();

        public int[] RollDices(int numberOfRolls)
        {
            int[] results = new int[11];

            for (int i = 0; i < numberOfRolls; i++)
            {
                int rollOne = random.Next(1, 7);
                int rollTwo = random.Next(1, 7);
                int sum = rollOne + rollTwo;

                results[sum - 2]++;
            }

            return results;
        }
    }
}
