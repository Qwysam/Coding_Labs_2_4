using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab3;

namespace UnitTestLab3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOperation1()
        {
            CustomArray MyArray = new CustomArray();
            int[] array = { 2551, 4488, 2858, 4554, 3780, 1297, 473 };
            int[] test_res = { 0, 10339 };
            CollectionAssert.AreEqual(test_res, MyArray.SumLessAndGreater(array, 570));
        }
        [TestMethod]
        public void TestOperation2()
        {
            CustomArray MyArray = new CustomArray();
            int[] array = { 1920,431,3465,89,1177,3080,1198 };
            int[] test_res = { 89, 431,1177,1198,1920,3080,3465 };
            CollectionAssert.AreEqual(test_res, MyArray.SortArray(array));
        }
        [TestMethod]
        public void TestOperation3()
        {
            CustomArray MyArray = new CustomArray();
            int[] array = { 4203,2479,1034,3072,351,3021,4083 };
            int[] test_res = { 4083,1 };
            CollectionAssert.AreEqual(test_res, MyArray.SumAndCountEven(array, 2000));
        }
        [TestMethod]
        public void TestOperation4()
        {
            CustomArray MyArray = new CustomArray();
            int[] array = { 2224,4388,4604,3433,1320,2290,1390 };
            int test_res = 1;
            Assert.AreEqual(test_res, MyArray.CountPrimes(array));
        }

    }
}
