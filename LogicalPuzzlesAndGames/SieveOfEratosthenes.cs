using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPuzzlesAndGames
{
    public class SieveOfEratosthenes
    {
        public static void Sieve_Of_Eratosthenes(int n)
        {
            // Given n, find all primes < n
            var sieveNumbers = new bool[n + 1];
            for (var i = 0; i < n; i++)
            {
                sieveNumbers[i] = true;
            }


            for (var i = 2; i < n; i++)
            {
                if (sieveNumbers[i])
                {
                    for (var c = i; i * c < n; c++)
                    {
                        sieveNumbers[i * c] = false;
                    }
                }
            }

            var counter = 0;
            for (var i = 2; i < n; i++)
            {
                if (sieveNumbers[i])
                {
                    Console.Write(i + ", ");
                    counter++;
                }

                if (counter == 10)
                {
                    Console.WriteLine("\n");
                    counter = 0;
                }

            }
        }

    }
}
