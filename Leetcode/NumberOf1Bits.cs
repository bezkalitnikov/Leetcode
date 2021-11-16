namespace Leetcode
{
    public class NumberOf1Bits
    {
        public int HammingWeight(uint n)
        {
            var bits = 0;

            for (int i = 0; i < 32; ++i)
            {
                if ((n & (1 << i)) != 0)
                {
                    bits += 1;
                }
            }

            return bits;
        }
    }
}