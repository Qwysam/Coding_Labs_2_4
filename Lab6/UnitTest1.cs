using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AnalogClock;
using System.Drawing;
using System.IO;

namespace UnitTestProjectLab6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestColorSet()
        {
            Form1.LinearBrush1 = Color.Red;
            Assert.AreEqual(Form1.LinearBrush1, Color.Red);
        }

        [TestMethod]
        public void TestColorDefault()
        {
            Form1 f = new Form1();
            Assert.AreEqual(Form1.Hour_Dash_Pen, Color.White);
        }

        [TestMethod]
        public void TestCDefaultSettings()
        {
            string settings = "-16744448\n-1\n-2894893\n-65536";
            string text = File.ReadAllText("C:\\Users\\zhdan\\Desktop\\Default_config.txt");
            Assert.AreEqual(settings,text);
        }
    }
}
