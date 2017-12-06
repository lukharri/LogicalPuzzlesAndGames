using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPuzzlesAndGames
{
    public class FizzBuzzLoop
    {
        public void FizzBuzz_Loop()
        {
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0 && i % 3 != 0)
                    Console.WriteLine("Buzz");
                else if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else Console.WriteLine(i);
            }
        }

    }
}
