using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPuzzlesAndGames
{
    public class FizzBuzzRecursion
    {
        public int FizzBuzz_Recursive(int i)
        {
            if (i == 101) return i;

            if (i % 3 == 0 && i % 5 != 0)
            {
                Console.WriteLine("Fizz");
                return FizzBuzz_Recursive(i + 1);
            }

            else if (i % 5 == 0 && i % 3 != 0)
            {
                Console.WriteLine("Buzz");
                return FizzBuzz_Recursive(i + 1);
            }

            else if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
                return FizzBuzz_Recursive(i + 1);
            }

            else
            {
                Console.WriteLine(i);
                return FizzBuzz_Recursive(i + 1);
            }
        }

    }
}
