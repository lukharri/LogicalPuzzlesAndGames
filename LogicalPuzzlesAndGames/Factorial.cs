using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPuzzlesAndGames
{
    class Factorial
    {
        public static int fac(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else return n * fac(n - 1);
        }

    }
}
