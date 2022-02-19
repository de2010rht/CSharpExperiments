using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using InheritancePolymorphismExpo.Classes;

namespace InheritancePolymorphismExpo.Tests
{
    [TestClass]
    public class TruckTest
    {
        private Vehicle vehicle;

        [TestMethod]
        public void TestTruckDrive()
        {
            vehicle = new Truck("TATA", "407", 6, 2, 2, "White", "Pune", 5.2, false);
            Assert.AreEqual("Driving TATA 407 on highway", vehicle.drive());
        }

        [TestMethod]
        public void TestTruckPrice()
        {
            vehicle = new Truck("Mahindra", "BLAZO", 10, 2, 3, "Black", "Pune", 8.75, true);
            Assert.AreEqual("Price of Mahindra BLAZO is more than $2,500,000.00", vehicle.getPrice());
        }

        [TestMethod]
        public void TestTruckLoadCap()
        {
            vehicle = new Truck("TATA", "Ultra", 6, 2, 2, "Black-N-White", "Pune", 11.25, true);
            Assert.AreEqual(11.25, ((Truck) vehicle).LoadCapacity);
        }

        [TestMethod]
        public void TestTruckProducedAtFactory()
        {
            vehicle = new Truck("Ashok Leyland", "Vexa", 8, 2, 2, "Green", "Chennai", 11, true);
            Assert.AreEqual("Chennai", ((Truck) vehicle).ProducedAt);
        }

        [TestMethod]
        public void TestTruckPermit()
        {
            vehicle = new Truck("TATA", "Ultra BS6", 8, 2, 2, "Yellow", "Pune", 12.5, true);
            Assert.IsTrue(((Truck) vehicle).IsNationalPermitCarrier);
        }
    }
}
