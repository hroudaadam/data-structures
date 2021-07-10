using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Stack
    {
        public int Count { get; private set; } = 0;
        private StackNode _top;

        public void Clear() 
        {
            _top = null;
            Count = 0;
        }

        public int Peek() 
        {
            if (Count <= 0) throw new InvalidOperationException("Stack is empty");

            return _top.Value;
        }

        public int Pop() 
        {
            if (Count <= 0) throw new InvalidOperationException("Stack is empty");

            StackNode tmp = _top;
            _top = _top.Next;
            Count--;

            return tmp.Value;
        }

        public void Push(int value) 
        {
            StackNode newNode = new(value, _top);
            _top = newNode;
            Count++;
        }

        public override string ToString()
        {
            List<int> values = new();
            StackNode curr = _top;

            while (curr != null)
            {
                values.Add(curr.Value);
                curr = curr.Next;
            }

            return string.Join(", ", values);
        }
    }

    class StackNode
    {
        public int Value { get; set; }
        public StackNode Next { get; set; }

        public StackNode(int value, StackNode next)
        {
            Value = value;
            Next = next;
        }
    }
}
