namespace Leetcode
{
    public class ClimbingStairs 
    {
        public int ClimbStairs(int n) 
        {
            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }
            
            var vector = new int[2];
            vector[0] = 1; // S(1)
            vector[1] = 2; // S(2)

            // S(n) = S(n-1) + S(n-2)
            for (var i = 3; i <= n; ++i)
            {
                var next = vector[1] + vector[0];
                (vector[0], vector[1]) = (vector[1], next);
            }

            return vector[1];
        }
    }
}