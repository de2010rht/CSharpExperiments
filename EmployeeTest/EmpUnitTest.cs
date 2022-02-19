using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EmployeeTest
{
    [TestClass]
    public class EmpUnitTest
    {
        private static Employee employee;
        [ClassInitialize]
        public static void BeforeClass(TestContext testContext)
        {
            employee = new Employee("Rohitaswa", "De", 33, 2040064, "Technology");
            Console.WriteLine(employee);
        }

        [TestMethod]
        public void TestEmpInfo()
        {
            Assert.AreEqual("Rohitaswa De, 2040064", employee.getEmployeeInfo());
        }

        [TestMethod]
        public void TestEmployeeLocation()
        {
            Assert.AreEqual("Work from Home", employee.getEmployeeLocation());
        }
    }
}
