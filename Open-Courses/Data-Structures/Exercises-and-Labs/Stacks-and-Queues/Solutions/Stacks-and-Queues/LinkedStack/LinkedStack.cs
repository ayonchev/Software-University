using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedStack
{
    public class LinkedStack<T> : ILinkedStack<T>, IEnumerable<T>
    {
        private class StackNode
        {
            public StackNode(T value)
            {
                Value = value;
            }
            public T Value { get; set; }
            public StackNode Prev { get; set; }
        }

        private StackNode top;
        public int Count { get; private set; }

        public void Push(T value)
        {
            StackNode newNode = new StackNode(value);
            newNode.Prev = this.top;
            this.top = newNode;

            Count++;
        }

        public T Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException();

            T topValue = this.top.Value;
            this.top = this.top.Prev;
            Count--;

            return topValue;
        }

        public T Peek()
        {
            return this.top != null ? this.top.Value : throw new InvalidOperationException();
        }

        public void Clear()
        {
            this.top = null;
            Count = 0;
        }

        public T[] ToArray()
        {
            T[] data = new T[Count];
            int index = 0;

            foreach (var element in this)
            {
                data[index] = element;
                index++;
            }

            return data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            StackNode current = this.top;

            while(current != null)
            {
                yield return current.Value;
                current = current.Prev;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
