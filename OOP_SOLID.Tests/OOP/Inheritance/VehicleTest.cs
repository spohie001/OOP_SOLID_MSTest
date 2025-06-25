using OOP_SOLID.OOP.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.Tests.OOP.Inheritance
{
    [TestClass]
    internal class VehicleTest
    {
        [TestMethod]
        public void AnyVehicle_StartTriggered_SuccesfullyStarted()
        {
            var car = new Car();
            var bike = new Bike();
            Assert.AreEqual("Starting vehicle", car.Start());
            Assert.AreEqual("Starting vehicle", bike.Start());
        }
    }
}
