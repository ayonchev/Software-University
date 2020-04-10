using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedStack
{
    public interface ILinkedStack<T>
    {
        public int Count { get; }

        void Push(T value);
        T Pop();
        T Peek();
        void Clear();
        T[] ToArray();
    }
}
