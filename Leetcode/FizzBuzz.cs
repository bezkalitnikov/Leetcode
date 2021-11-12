using System.Collections.Generic;

namespace Leetcode
{
    public class FizzBuzzContainer
    {
        public IList<string> FizzBuzz(int n)
        {
            List<string> result = new();

            for (var i = 1; i <= n; ++i)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                    continue;
                }

                if (i % 3 == 0)
                {
                    result.Add("Fizz");
                    continue;
                }

                if (i % 5 == 0)
                {
                    result.Add("Buzz");
                    continue;
                }

                result.Add(i.ToString());
            }

            return result;
        }
    }
}