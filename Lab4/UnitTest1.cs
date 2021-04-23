using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab4;

namespace Lab4_Tests
{
    [TestClass]
    public class UnitTest1
    {
        private void SetArray(Tmas matr)
        {
            matr.FA = new int[5, 5];
            int[,] arr;
            arr = new int[5, 5]{ {-56, 348, -51, 396, 259},
                        {-52, -78, 188, 355, 128},
                        { 294, 279, 303, 199, 471},
                        { 151, 128, 397, 147, 313},
                        { 104, 276, 206, 459, 99 }};
            Array.Copy(arr, matr.FA, arr.Length);
        }
        [TestMethod]
        public void CheckIndexInBounds()
        {
            Tmas test = new Tmas();
            SetArray(test);
            Assert.AreEqual(test.CheckIndex(0, 2), true);
        }
        [TestMethod]
        public void CheckIndexOutOfBounds()
        {
            Tmas test = new Tmas();
            SetArray(test);
            Assert.AreEqual(test.CheckIndex(10, 2), false);
        }
        [TestMethod]
        public void GenerateMatrix()
        {
            Tmas test = new Tmas();
            test.GenerateMatrix(-100, 500, 5);
            Assert.AreEqual(test.FA != null, true);
        }
        [TestMethod]
        public void SortColumns()
        {
            Tmas test = new Tmas();
            SetArray(test);
            test.SortColumns();
            int[,] mask;
            mask = new int[5, 5]{ {294, 348, 397, 459, 471},
                        { 151, 279, 303, 396, 313},
                        { 104, 276, 206, 355, 259},
                        { -52, 128, 188, 199, 128},
                        { -56, -78, -51, 147, 99 }};
            CollectionAssert.AreEqual(test.res, mask);
        }
        [TestMethod]
        public void MaxElem()
        {
            Tmas test = new Tmas();
            SetArray(test);
            Assert.AreEqual(test.MaxElem(test.FA), 471);
        }

        [TestMethod]
        public void MinusB()
        {
            Tmas test = new Tmas();
            SetArray(test);
            int[,] mask;
            mask = new int[5, 5]{
                { -62, 342, -57, 390, 253 },
                { -58, -84, 182, 349, 122 },
                { 288, 273, 297, 193, 465 },
                { 145, 122, 391, 141, 307 },
                { 98,  270, 200, 453, 93 },
            };
            test.MinusB(6);
            CollectionAssert.AreEqual(test.res, mask);
        }
    }
}
