using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    //class Node
    //{
    //    public Node(int val, int min)
    //    {
    //        this.val = val;
    //        this.min = min;
    //    }
    //    public int val;
    //    public int min;
    //}
    public class MinStack
	{
        class Node
        {
            public Node(int val, int min)
            {
                this.val = val;
                this.min = min;
            }
            public int val;
            public int min;
        }

        private Stack<Node> _stack;
        /** initialize your data structure here. */
        public MinStack()
        {
            _stack = new Stack<Node>();
        }

        public void Push(int x)
        {
            var currentMin = _stack.Count > 0 ? Math.Min(_stack.Peek().min, x) : x;
            _stack.Push(new Node(x, currentMin));
        }

        public void Pop()
        {
            _stack.Pop();
        }

        public int Top()
        {
            return _stack.Peek().val;
        }

        public int GetMin()
        {
            return _stack.Peek().min;
        }
    }
}
