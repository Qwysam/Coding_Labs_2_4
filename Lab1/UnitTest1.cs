using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace UnitTestProjectLab1
{
    [TestClass]
    public class UnitTest1
    {
        //two tests for + method
        [TestMethod]
        public void TestSumMethod1()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(2);
            double b = 2;
            //Act
            double ressult = calculator.Sum(b);
            //Assert
            double actual = 4;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestSumMethod2()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(-10);
            double b = 5;
            //Act
            double ressult = calculator.Sum(b);
            //Assert
            double actual = -5;
            Assert.AreEqual(ressult, actual);
        }
        //Two tests - metod
        [TestMethod]
        public void TestSubMethod1()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(50);
            double b = 10;
            //Act
            double ressult = calculator.Subtraction(b);
            //Assert
            double actual = 40;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestSubMethod2()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(-50);
            double b = 10;
            //Act
            double ressult = calculator.Subtraction(b);
            //Assert
            double actual = -60;
            Assert.AreEqual(ressult, actual);
        }
        //three tests * method
        [TestMethod]
        public void TestMultiplicationMethod1()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(40);
            double b = 10;
            //Act
            double ressult = calculator.Multiplication(b);
            //Assert
            double actual = 400;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestMultiplicationMethod2()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(0);
            double b = 10;
            //Act
            double ressult = calculator.Multiplication(b);
            //Assert
            double actual = 0;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestMultiplicationMethod3()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(-40);
            double b = 10;
            //Act
            double ressult = calculator.Multiplication(b);
            //Assert
            double actual = -400;
            Assert.AreEqual(ressult, actual);
        }
        // tests / methdo
        [TestMethod]
        public void TestDivisionMethod1()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(40);
            double b = 10;
            //Act
            double ressult = calculator.Division(b);
            //Assert
            double actual = 4;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestDivisionMethod2()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(0);
            double b = 10;
            //Act
            double ressult = calculator.Division(b);
            //Assert
            double actual = 0;
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestDivisionMethod3()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(40);
            double b = 0;
            //Act
            double ressult = calculator.Division(b);
            //Assert
            double actual = 0;
            Assert.AreEqual(ressult, actual);
        }
        //Test sin method
        [TestMethod]
        public void TestSinMethod1()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(40);
            //Act
            double ressult = calculator.sin();
            //Assert
            double actual = Math.Sin(40);
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestSinMethod2()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(0);
            //Act
            double ressult = calculator.sin();
            //Assert
            double actual = Math.Sin(0);
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestSinMethod3()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(-40);
            //Act
            double ressult = calculator.sin();
            //Assert
            double actual = Math.Sin(-40);
            Assert.AreEqual(ressult, actual);
        }
        //tests sqrt method
        [TestMethod]
        public void TestSqrtMethod1()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(40);
            //Act
            double ressult = calculator.Sqrt();
            //Assert
            double actual = Math.Sqrt(40);
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestSqrtMethod2()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(0);
            //Act
            double ressult = calculator.Sqrt();
            //Assert
            double actual = Math.Sqrt(0);
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestSqrtMethod3()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(-40);
            //Act
            double ressult = calculator.Sqrt();
            //Assert
            double actual = Math.Sqrt(-40);
            Assert.AreEqual(ressult, actual);
        }
        // Test Square method
        [TestMethod]
        public void TestSquareMethod1()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(40);
            //Act
            double ressult = calculator.Square();
            //Assert
            double actual = Math.Pow(40, 2);
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestSquareMethod2()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(0);
            //Act
            double ressult = calculator.Square();
            //Assert
            double actual = Math.Pow(0, 2);
            Assert.AreEqual(ressult, actual);
        }
        [TestMethod]
        public void TestSquareMethod3()
        {
            //Arrange
            Form1 calculator = new Form1();
            calculator.Put_A(-40);
            //Act
            double ressult = calculator.Square();
            //Assert
            double actual = Math.Pow(-40, 2);
            Assert.AreEqual(ressult, actual);
        }
    }
}
