using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPuzzlesAndGames
{
    public class Craps
    {
        private static Random rand = new Random();
        private static int rollCounter = 0;
        private static int FirstRoll;
        private static int NextRoll;

        public enum RollNames
        {
            SnakeEyes = 2,
            Trey = 3,
            Seven = 7,
            YoLeven = 11,
            BoxCars = 12
        }


        public static int RollDice()
        {
            var die1 = rand.Next(1, 7);
            var die2 = rand.Next(1, 7);
            rollCounter++;
            return die1 + die2;
        }


        public static void GameResult(int point)
        {
            if (rollCounter == 1 && (point == 7 || point == 11 || point == 2 || point == 3 || point == 12))
            {
                switch (point)
                {
                    case 7:
                        Console.WriteLine((RollNames)point + "! You win!");
                        break;
                    case 11:
                        Console.WriteLine((RollNames)point + "! You win!");
                        break;
                    case 2:
                        Console.WriteLine((RollNames)point + "! You lose!");
                        break;
                    case 3:
                        Console.WriteLine((RollNames)point + "! You lose!");
                        break;
                    case 12:
                        Console.WriteLine((RollNames)point + "! You lose!");
                        break;
                }
            }
            else
            {
                Console.WriteLine(point + ". Hit 'Enter' to Roll again.");
                Console.ReadLine();
                FirstRoll = point;
                NextRoll = RollDice();
                while (FirstRoll != NextRoll)
                {
                    if (NextRoll == 7)
                    {
                        Console.WriteLine((RollNames)NextRoll + "! You lose!");
                        break;
                    }
                    else
                    {
                        NextRoll = RollDice();
                    }
                }

                if (FirstRoll == NextRoll) Console.WriteLine(NextRoll + "! You win!");

            }  
        }
    }
}
