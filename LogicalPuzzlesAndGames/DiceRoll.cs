using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPuzzlesAndGames
{
    public class DiceRoll
    {
        private static Random rand = new Random();
        private static int[] sums = new int[13];
        private static int[] dieOneSums = new int[7];
        private static int[] dieTwoSums = new int[7];

        public static void Rolls(int rolls)
        {
            while(rolls > 0)
            {
                var sum = RollDice();
                RecordStats(sum);
                rolls--;
            }
            DisplayResults();
        }

        private static int RollDice()
        {
            var die1 = rand.Next(1, 7);
            dieOneSums[die1] += 1;
            var die2 = rand.Next(1, 7);
            dieTwoSums[die2] += 1;

            return die1 + die2;
        }

        private static void RecordStats(int sum)
        {
            switch (sum)
            {
                case 2:
                    sums[2] += 1;
                    break;
                case 3:
                    sums[3] += 1;
                    break;
                case 4:
                    sums[4] += 1;
                    break;
                case 5:
                    sums[5] += 1;
                    break;
                case 6:
                    sums[6] += 1;
                    break;
                case 7:
                    sums[7] += 1;
                    break;
                case 8:
                    sums[8] += 1;
                    break;
                case 9:
                    sums[9] += 1;
                    break;
                case 10:
                    sums[10] += 1;
                    break;
                case 11:
                    sums[11] += 1;
                    break;
                case 12:
                    sums[12] += 1;
                    break;
            }
        }

        private static void DisplayResults()
        {
            for(var i = 2; i <= 12; i++)
            {
                Console.WriteLine("Sum of " + i + " occured " + sums[i] + " times.");
            }
        }
    }
}
