using System;

namespace Leetcode
{
    public class RomanToInteger
    {
        public int RomanToInt(string s) 
        {
            int total = 0;
            for (var i = s.Length - 1; i >= 0; --i)
            {
                switch(s[i])
                {
                    case 'I' when i < s.Length - 1 && s[i + 1] == 'V':
                    case 'I' when i < s.Length - 1 && s[i + 1] == 'X':
                        total -= 1;
                        break;
                    case 'I':
                        total += 1;
                        break;
                    case 'V':
                        total += 5;
                        break;
                    case 'X' when i < s.Length - 1 && s[i + 1] == 'L':
                    case 'X' when i < s.Length - 1 && s[i + 1] == 'C':
                        total -= 10;
                        break;
                    case 'X':
                        total += 10;
                        break;
                    case 'L':
                        total += 50;
                        break;
                    case 'C' when i < s.Length - 1 && s[i + 1] == 'D':
                    case 'C' when i < s.Length - 1 && s[i + 1] == 'M':
                        total -= 100;
                        break;
                    case 'C':
                        total += 100;
                        break;
                    case 'D':
                        total += 500;
                        break;
                    case 'M':
                        total += 1000;
                        break;
                }
            }

            return total;
        }
    }
}