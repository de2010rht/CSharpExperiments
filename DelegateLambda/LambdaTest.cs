using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DelegateLambda
{
    [TestClass]
    public class LambdaTest
    {
        [TestMethod]
        public void TestDelegate()
        {
            DelegateDemo.Exec();
            DelegateDemo.Process();
            Assert.IsTrue(true);
        }

        delegate int Square(int a);
        [TestMethod]
        public void TestFirstLambda()
        {
            Square square = x => x * x;
            int sqr = square(5);
            Assert.AreEqual(25, sqr);
        }

        [TestMethod]
        public void TestListLambda()
        {
            List<int> listOfIntegers = new List<int>() { 10, 20, 31, 40 };
            int oddIndex = listOfIntegers.FindIndex(x => x % 2 != 0);
            Assert.AreEqual(2, oddIndex);
        }

        delegate string Welcome(string s);
        [TestMethod]
        public void TestStatementLambda()
        {
            Welcome welcome = s =>
            {
                string str = "Hello " + s;
                Console.WriteLine(str);
                return str;
            };
            Assert.AreEqual("Hello Sam", welcome("Sam"));
        }
    }
}
