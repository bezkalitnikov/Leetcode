namespace Leetcode
{
    public class PowerOfThree
    {
        // 3^19
        private const int nineteenPowerOfThree = 1_162_261_467;

        public bool IsPowerOfThree(int n)
        {
            if (n < 1)
            {
                return false;
            }
            
            // Regarding to problem constraint
            // -2^31 <= n <= 2^31 - 1
            // 2^31 - 1 is close to 3^19
            // if n is power of three than next 
            // would be true 3^19 mod n == 0

            return nineteenPowerOfThree % n == 0;
        }
    }
}