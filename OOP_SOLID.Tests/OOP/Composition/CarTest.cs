using OOP_SOLID.OOP.Composition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.Tests.OOP.Composition
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Car_StartTriggered_UsedAllPartsOfMechanism()
        {
            var car = new Car();
            var actions = car.Start();
            Assert.AreEqual(4, actions.Count);
        }
    }
}
