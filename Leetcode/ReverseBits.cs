namespace Leetcode
{
    public class ReverseBitsContainer 
    {
        public uint ReverseBits(uint x)
        {
            var result = 0U;

            for (var i = 0; i < 32; ++i)
            {
                result |= 1 & x;
                if (i < 31)
                {
                    x >>= 1;
                    result <<= 1;
                }
            }

            return result;
        }
    }
}