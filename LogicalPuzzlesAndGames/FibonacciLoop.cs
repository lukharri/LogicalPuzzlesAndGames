using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPuzzlesAndGames
{
    public class FibonacciLoop
    {
        public void Fiboccani_Loop()
        {
            var num1 = 0;
            var num2 = 1;

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            for (int i = 0; i < 15; i++)
            {
                var next = num1 + num2;
                num1 = num2;
                num2 = next;

                Console.WriteLine(next);
            }
        }


    }
}
