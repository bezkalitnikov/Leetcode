namespace Leetcode
{
    public class HammingDistanceContainer
    {
        public int HammingDistance(int x, int y)
        {
            int total = 0;

            var xor = x ^ y;

            for (var i = 0; i < 32; ++i)
            {
                if (((1 << i) & xor) != 0)
                {
                    total++;
                }
            }

            return total;
        }
    }
}