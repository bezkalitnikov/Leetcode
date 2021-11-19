using System.Collections.Generic;

namespace Leetcode
{
    public class ValidParentheses
    {
        public bool IsValid(string s) 
        {
            if (s.Length % 2 != 0)
            {
                return false;
            }

            var stack = new Stack<char>();

            foreach(var ch in s)
            {
                switch (ch)
                {
                    case '{':
                    case '[':
                    case '(':
                        stack.Push(ch);
                        break;
                    case '}':
                    case ']':
                    case ')':
                        if (stack.TryPop(out var open))
                        {
                            if (ch == '}' && open == '{'
                            || ch == ']' && open == '['
                            || ch == ')' && open == '(')
                            {
                                continue;
                            }
                        }
                        return false;
                    default:
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}