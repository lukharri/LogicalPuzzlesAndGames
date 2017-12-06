using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPuzzlesAndGames
{
    public class FibonacciRecursion
    {
        public int Fibonacci_Recursion(int n)
        {
            if (n <= 1)
                return 1;
            return Fibonacci_Recursion(n - 2) + Fibonacci_Recursion(n - 1);
        }


    }
}
