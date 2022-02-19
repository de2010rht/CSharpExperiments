using MathematicsOverloaded;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathematicsOverloadedUnitTest
{
    [TestClass]
    public class MathsOverloadedTests
    {
        private static MathHelper mathHelper;

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            mathHelper = new MathHelper();
        }

        [TestMethod]
        public void TestSumInt()
        {
            Assert.AreEqual(21, mathHelper.sum(13, 8));
        }

        [TestMethod]
        public void TestSumDouble()
        {
            Assert.AreEqual(19, mathHelper.sum(10.5, 8.5));
        }

        [TestMethod]
        public void TestSumDecimal()
        {
            Assert.AreEqual(14.8M, mathHelper.sum(5.6M, 9.2M));
        }

        [TestMethod]
        public void TestSumIntNamed()
        {
            Assert.AreEqual(3, mathHelper.sum(1, b: 2));
        }

        [TestMethod]
        public void TestSumIntNamedBoth()
        {
            Assert.AreEqual(16, mathHelper.sum(a: 11, b: 5));
        }

        [TestMethod]
        public void TestSumOptional1()
        {
            int num = 0;
            Assert.AreEqual(10, mathHelper.sumOptional(num));
        }

        [TestMethod]
        public void TestSumOptional2()
        {
            Assert.AreEqual(33, mathHelper.sumOptional(11, 22));
        }

        [TestMethod]
        public void TestSumOptionalBoth1()
        {
            Assert.AreEqual(60, mathHelper.sumOptionalBoth());
        }

        [TestMethod]
        public void TestSumOptionalBoth2()
        {
            Assert.AreEqual(32, mathHelper.sumOptionalBoth(22));
        }

        [TestMethod]
        public void TestSumOptionalBoth3()
        {
            Assert.AreEqual(94, mathHelper.sumOptionalBoth(num2: 44));
        }

        [TestMethod]
        public void TestNumOut()
        {
            int digit;      // No initialization required for 'out'
            mathHelper.numOut(out digit);
            Assert.AreEqual(105, digit);
        }

        [TestMethod]
        public void TestNumRef()
        {   
            int number = 1;     // Initialization must for 'ref'
            mathHelper.numRef(ref number);
            Assert.AreEqual(420, number);
        }
    }
}
