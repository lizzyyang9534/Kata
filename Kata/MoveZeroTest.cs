using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata
{
    [TestClass]
    public class MoveZeroTest
    {
        [TestMethod]
        public void Test_empty()
        {
            var actual = MoveZero.MoveZeroes(new int[] { });
            CollectionAssert.AreEqual(new int[] { }, actual);
        }

        [TestMethod]
        public void Test_1()
        {
            var actual = MoveZero.MoveZeroes(new int[] { 1 });
            CollectionAssert.AreEqual(new int[] { 1 }, actual);
        }

        [TestMethod]
        public void Test_123()
        {
            var actual = MoveZero.MoveZeroes(new int[] { 1, 2, 3 });
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, actual);
        }

        [TestMethod]
        public void Test_0()
        {
            var actual = MoveZero.MoveZeroes(new int[] { 0 });
            CollectionAssert.AreEqual(new int[] { 0 }, actual);
        }

        [TestMethod]
        public void Test_0123()
        {
            var actual = MoveZero.MoveZeroes(new int[] { 0, 1, 2, 3 });
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 0 }, actual);
        }

        [TestMethod]
        public void Test_1230()
        {
            var actual = MoveZero.MoveZeroes(new int[] { 1, 2, 3, 0 });
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 0 }, actual);
        }

        [TestMethod]
        public void Test_00123()
        {
            var actual = MoveZero.MoveZeroes(new int[] { 0, 0, 1, 2, 3 });
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 0, 0 }, actual);
        }

        [TestMethod]
        public void Test_01023()
        {
            var actual = MoveZero.MoveZeroes(new int[] { 0, 1, 0, 2, 3 });
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 0, 0 }, actual);
        }

        [TestMethod]
        public void Test_01230()
        {
            var actual = MoveZero.MoveZeroes(new int[] { 0, 1, 2, 3, 0 });
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 0, 0 }, actual);
        }

        [TestMethod]
        public void Test_001023()
        {
            var actual = MoveZero.MoveZeroes(new int[] { 0, 0, 1, 0, 2, 3 });
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 0, 0, 0 }, actual);
        }

        [TestMethod]
        public void Test_102003()
        {
            var actual = MoveZero.MoveZeroes(new int[] { 1, 0, 2, 0, 0, 3 });
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 0, 0, 0 }, actual);
        }

        [TestMethod]
        public void Test_0000()
        {
            var actual = MoveZero.MoveZeroes(new int[] { 0, 0, 0, 0 });
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0 }, actual);
        }
    }
}