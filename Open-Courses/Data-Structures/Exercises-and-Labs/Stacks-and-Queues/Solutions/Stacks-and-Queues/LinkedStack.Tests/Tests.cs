using NUnit.Framework;
using System;

namespace LinkedStack.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StackPushesValuesSuccessfully()
        {
            LinkedStack<int> stack = new LinkedStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(-32);
            stack.Push(-44);

            Assert.AreEqual(stack.Count, 4);
            Assert.AreEqual(stack.Pop(), -44);
            Assert.AreEqual(stack.Count, 3);
        }

        [Test]
        public void StackPopsValueSuccessfully()
        {
            LinkedStack<int> stack = new LinkedStack<int>();
            for (int i = 10; i >= 1; i--)
            {
                stack.Push(i);
            }

            Assert.AreEqual(stack.Count, 10);

            for (int i = 1; i <= 10; i++)
            {
                Assert.AreEqual(stack.Pop(), i);
            }

            Assert.AreEqual(stack.Count, 0);
        }

        [Test]
        public void EmptyStackThrowsException()
        {
            LinkedStack<int> stack = new LinkedStack<int>();

            Assert.AreEqual(stack.Count, 0);
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Test]
        public void ClearEmptiesStack()
        {
            LinkedStack<int> stack = new LinkedStack<int>();

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            Assert.AreEqual(stack.Count, 10);
            stack.Clear();
            Assert.AreEqual(stack.Count, 0);
        }

        [Test]
        public void ToArrayReturnsProperArray()
        {
            LinkedStack<int> stack = new LinkedStack<int>();

            for (int i = 1; i <= 5; i++)
            {
                stack.Push(i);
            }

            int[] stackData = stack.ToArray();
            int[] expectedData = new int[] { 5, 4, 3, 2, 1 };

            for (int index = 0; index < stackData.Length; index++)
            {
                Assert.AreEqual(stackData[index], expectedData[index]);
            }
        }
    }
}