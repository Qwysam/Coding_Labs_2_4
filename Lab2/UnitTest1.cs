using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab2;

namespace Lab2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNegativeD()
        {
            double?[] test_arr = { null, null };
            CollectionAssert.AreEqual(test_arr, Calculation.ShowRoots(3, 4, 2));
        }
        [TestMethod]
        public void TestZeroD()
        {
            double?[] test_arr = { -1, null };
            CollectionAssert.AreEqual(test_arr, Calculation.ShowRoots(2, 4, 2));
        }
        [TestMethod]
        public void TestPositiveD()
        {
            //d = 8
            //x1=4+sqrt8/
            double?[] test_arr = { 7, -3 };
            CollectionAssert.AreEqual(test_arr, Calculation.ShowRoots(1, -4, -21));
        }
    }
}
