using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    [TestCategory("Library Method Validation")]
    public class UnitTestMaths
    {
        private static TestContext _testContext;
        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            _testContext = testContext;
            System.Diagnostics.Debug.WriteLine("Class Initializer called!");
        }

        [TestInitialize]
        public void InitializeTest()
        {
            System.Diagnostics.Debug.WriteLine("Test Initializer called!");
        }

        [TestMethod]
        [TestCategory("Positive")]
        public void TestMethodAdd()
        {
            Assert.AreEqual(15, ClassLibraryProgram.Maths.add(10, 5));
        }

        [TestMethod]
        [TestCategory("Negative")]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethodAddFail()
        {
            Assert.AreEqual(14, ClassLibraryProgram.Maths.add(10, 5));
        }

        [TestCleanup]
        public void CleanTest()
        {
            System.Diagnostics.Debug.WriteLine("Test Cleanup called!");
        }

        [ClassCleanup]
        public static void CleanClass()
        {
            System.Diagnostics.Debug.WriteLine("Class Cleanup called!");
        }
    }
}
