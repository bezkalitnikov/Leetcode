using System.Collections.Generic;

namespace Leetcode
{
    public class MinStack
    {
        private readonly Stack<int> _stack = new();

        private readonly Stack<int> _min = new();

        public void Push(int val)
        {
            _stack.Push(val);

            if (_min.Count == 0 || _min.Peek() >= val)
            {
                _min.Push(val);
            }
        }
        
        public void Pop()
        {
            var val = _stack.Pop();
            if (val == _min.Peek())
            {
                _min.Pop();
            }
        }
        
        public int Top()
        {
            return _stack.Peek();
        }
        
        public int GetMin()
        {
            return _min.Peek();
        }
    }
}