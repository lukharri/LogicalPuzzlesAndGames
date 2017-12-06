using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPuzzlesAndGames
{
    public class TowerOfHanoi
    {
        public static int counter = 1;
        public void Tower_Of_Hanoi(int numOfDiscs, int sourcePeg, int destPeg, int sparePeg)
        {
            if (numOfDiscs == 1)
            {
                Console.WriteLine(counter + ": " + sourcePeg + " -> " + destPeg);
                counter++;
            }
            else
            {
                Tower_Of_Hanoi(numOfDiscs - 1, sourcePeg, sparePeg, destPeg);
                Console.WriteLine(counter + ": " + sourcePeg + " -> " + destPeg);
                counter++;
                Tower_Of_Hanoi(numOfDiscs - 1, sparePeg, destPeg, sourcePeg);
            }
        }

    }
}
