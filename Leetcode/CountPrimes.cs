using System.Linq;

namespace Leetcode
{
    public class CountPrimesContainer
    {
        public int CountPrimes(int n) 
        {
            var primes = new bool[n];

            for (var i = 2; i < n; ++i)
            {
                primes[i] = true;
            }

            for (var i = 2; i * i < n; ++i)
            {
                if (!primes[i])
                {
                    continue;
                }

                for (var j = i * i; j < n; j += i)
                {
                    primes[j] = false;
                }
            }

            var countPrimes = 0;

            for (var i = 2; i < n; ++i)
            {
                if (primes[i])
                {
                    ++countPrimes;
                }
            }

            return countPrimes;
        }
    }
}