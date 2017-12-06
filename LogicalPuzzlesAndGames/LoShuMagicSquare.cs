using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPuzzlesAndGames
{
    public class LoShuMagicSquare
    {
        private static Random rand = new Random();
        private static int[,] square = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        private static int counter;

        // Lo Shu Magic Square is a 3x3 grid in which the sums of each column,
        // row, and diagonal are the same
        public void LoShu()
        {
            while (!IsMagicSquare())
            {
                counter++;
                Console.WriteLine(counter);
                SwitchCells();

            }
            DisplayBoard();
        }


        private static bool IsMagicSquare()
        {
            if (
               (square[0, 0] + square[0, 1] + square[0, 2] == 15) &&
               (square[1, 0] + square[1, 1] + square[1, 2] == 15) &&
               (square[2, 0] + square[2, 1] + square[2, 2] == 15) &&

               (square[0, 0] + square[1, 0] + square[2, 0] == 15) &&
               (square[0, 1] + square[1, 1] + square[2, 1] == 15) &&
               (square[0, 2] + square[1, 2] + square[2, 2] == 15) &&

               (square[0, 0] + square[1, 1] + square[2, 2] == 15) &&
               (square[0, 2] + square[1, 1] + square[2, 0] == 15)
               )
            {
                return true;
            }
            else return false;
        }

        private void SwitchCells()
        {
            int[] number1 = new int[2];
            int[] number2 = new int[2];

            number1[0] = rand.Next(0, 3);
            number1[1] = rand.Next(0, 3);
            number2[0] = rand.Next(0, 3);
            number2[1] = rand.Next(0, 3);

            int temp = square[number1[0], number1[1]];
            square[number1[0], number1[1]] = square[number2[0], number2[1]];
            square[number2[0], number2[1]] = temp;
        }


        private static void DisplayBoard()
        {
            for( var row = 0; row < 3; row++)
            {
                for (var col = 0; col < 3; col++)
                {
                    Console.Write(square[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
