using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayStack.Tests
{
    [TestClass]
    public class ArrayStackTests
    {

        [TestMethod]
        public void StackPushesValuesSuccessfully()
        {
            ArrayStack<int> stack = new ArrayStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(-32);
            stack.Push(-44);

            Assert.AreEqual(stack.Count, 4);
            Assert.AreEqual(stack.Pop(), -44);
            Assert.AreEqual(stack.Count, 3);
        }

        [TestMethod]
        public void StackPopsValueSuccessfully()
        {
            ArrayStack<int> stack = new ArrayStack<int>();
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

        [TestMethod]
        public void EmptyStackThrowsException()
        {
            ArrayStack<int> stack = new ArrayStack<int>();

            Assert.AreEqual(stack.Count, 0);
            Assert.ThrowsException<InvalidOperationException>(() => stack.Pop());
            Assert.ThrowsException<InvalidOperationException>(() => stack.Peek());
        }

        [TestMethod]
        public void ToArrayReturnsProperArray()
        {
            ArrayStack<int> stack = new ArrayStack<int>();

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
