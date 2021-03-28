using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearchTree.Tests
{
    [TestClass]
    public class BinarySearchTreeTests
    {
        [TestMethod]
        public void DeleteMin_CountUpdate_ShouldBeSuccessful()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(1);

            Assert.AreEqual(3, tree.Count());

            tree.DeleteMin();

            Assert.AreEqual(2, tree.Count());

            tree.DeleteMin();

            Assert.AreEqual(1, tree.Count());

            tree.DeleteMin();

            Assert.ThrowsException<InvalidOperationException>(() => tree.DeleteMin());
        }

        [TestMethod]
        public void DeleteMax_CountUpdate_ShouldBeSuccessful()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(1);

            Assert.AreEqual(3, tree.Count());

            tree.DeleteMax();

            Assert.AreEqual(2, tree.Count());

            tree.DeleteMax();

            Assert.AreEqual(1, tree.Count());

            tree.DeleteMax();

            Assert.ThrowsException<InvalidOperationException>(() => tree.DeleteMax());
        }

        [TestMethod]
        public void Floor()
        {

        }
        [TestMethod]
        public void Floor_LowestValueOfTree_ShouldThrowError()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Insert(1);
            tree.Insert(3);
            tree.Insert(4);

            Assert.ThrowsException<InvalidOperationException>(() => tree.Floor(1));
        }

        [TestMethod]
        public void Floor_NonExistentValue_ShouldThrowError()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Insert(1);
            tree.Insert(3);
            tree.Insert(4);

            Assert.ThrowsException<InvalidOperationException>(() => tree.Floor(2));
        }

        [TestMethod]
        public void Floor_FindingValueInLinearTree_ShouldBeSuccessful()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Insert(1);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(5);

            Assert.AreEqual(3, tree.Floor(4));
        }

        [TestMethod]
        public void Floor_FindingValueInNormalTree_ShouldBeSuccessful()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Insert(10);
            tree.Insert(7);
            tree.Insert(4);
            tree.Insert(3);
            tree.Insert(1);
            tree.Insert(5);
            tree.Insert(6);
            tree.Insert(8);
            tree.Insert(9);
            tree.Insert(20);
            tree.Insert(19);
            tree.Insert(25);

            Assert.AreEqual(4, tree.Floor(7));
            Assert.AreEqual(7, tree.Floor(8));
            Assert.AreEqual(10, tree.Floor(20));
            Assert.AreEqual(20, tree.Floor(25));
        }
    }
}
