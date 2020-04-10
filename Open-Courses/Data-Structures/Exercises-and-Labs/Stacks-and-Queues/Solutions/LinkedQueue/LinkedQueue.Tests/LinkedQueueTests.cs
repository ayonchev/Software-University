using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedQueue.Tests
{
    [TestClass]
    public class LinkedQueueTests
    {
        [TestMethod]
        public void ShouldEnqueueElementsCorrectly()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            Assert.AreEqual(queue.Head.Data, 0);
            Assert.AreEqual(queue.Tail.Data, 9);
        }

        [TestMethod]
        public void ShouldDequeueElementsCorrectly()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();
            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue(i);
            }

            Assert.AreEqual(queue.Count, 5);

            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(queue.Dequeue(), i);
            }

            Assert.AreEqual(queue.Count, 0);
            Assert.ThrowsException<InvalidOperationException>(() => queue.Dequeue());
        }

        [TestMethod]
        public void ShouldReturnProperArray()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();
            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue(i);
            }

            int[] array = new int[5] { 0, 1, 2, 3, 4 };
            int[] returnedArray = queue.ToArray();

            for (int i = 0; i < returnedArray.Length; i++)
            {
                Assert.AreEqual(array[i], returnedArray[i]);
            }
        }
    }
}
