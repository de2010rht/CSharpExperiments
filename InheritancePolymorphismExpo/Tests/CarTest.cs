using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using InheritancePolymorphismExpo.Classes;

namespace InheritancePolymorphismExpo
{
    [TestClass]
    public class CarTest
    {
        private Vehicle vehicle;

        [TestMethod]
        public void TestFamilyCarDrive()
        {
            vehicle = new FamilyCar("TATA", "Punch", 4, 4, 5, "Blue", "Power", 650000M);
            Assert.AreEqual("Driving TATA Punch on road", vehicle.drive());
        }

        [TestMethod]
        public void TestFamilyCarPtice()
        {
            vehicle = new FamilyCar("TATA", "Nexon", 4, 4, 5, "Red", "Power", 630000M);
            Assert.AreEqual("Price of TATA Nexon - $630,000.00", vehicle.getPrice());
        }

        [TestMethod]
        public void TestFamilyCarSteering()
        {
            vehicle = new FamilyCar("Maruti Suzuki", "Baleno", 4, 4, 5, "Silver", "Power", 640000M);
            Assert.AreEqual("Power", ((FamilyCar) vehicle).SteeringType);
        }
    }
}
